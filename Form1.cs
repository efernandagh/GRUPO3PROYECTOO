using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace INICIO
{
    public partial class Form1 : Form
    {
        private string servidor = "";
        private ConexionBD conexionDB = new ConexionBD();
        private string rutaConfig = "configuracion.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private string ObtenerServidorSQL()
        {
            string nombrePC = Environment.MachineName;
            string[] posiblesInstancias = { "SQLEXPRESS", "MSSQLSERVER", "SQL2019", "ENIAGOMEZ" };

            foreach (string instancia in posiblesInstancias)
            {
                string servidorPrueba = $"Server={nombrePC}\\{instancia};Integrated Security=True;TrustServerCertificate=True;";
                try
                {
                    using (SqlConnection con = new SqlConnection(servidorPrueba))
                    {
                        con.Open();
                        return servidorPrueba;
                    }
                }
                catch
                {
                    continue;
                }
            }

            string servidorDefault = $"Server={nombrePC};Integrated Security=True;TrustServerCertificate=True;";
            try
            {
                using (SqlConnection con = new SqlConnection(servidorDefault))
                {
                    con.Open();
                    return servidorDefault;
                }
            }
            catch
            {
                MessageBox.Show("❌ No se pudo conectar a SQL Server en este equipo.\nVerifique que esté instalado y ejecutándose.",
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void VerificarConfiguracion()
        {
            try
            {
                if (File.Exists(rutaConfig))
                {
                    string[] lineas = File.ReadAllLines(rutaConfig);
                    bool tieneSQL = Array.Exists(lineas, l => l.Contains("SQL=SI"));
                    bool tieneBD = Array.Exists(lineas, l => l.Contains("BD=SI"));

                    if (!tieneSQL)
                    {
                        MessageBox.Show("Debe instalar SQL Server antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                        return;
                    }

                    if (!tieneBD)
                    {
                        DialogResult crearBD = MessageBox.Show("¿Desea crear la base de datos automáticamente?",
                            "Crear Base de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (crearBD == DialogResult.Yes)
                            CrearBaseDeDatos();
                        else
                        {
                            MessageBox.Show("No se puede continuar sin la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                    }
                }
                else
                {
                    // Si no existe el archivo, verificar directamente la BD
                    VerificarBaseDeDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la verificación: " + ex.Message);
            }
        }

        private void VerificarBaseDeDatos()
        {
            try
            {
                string cadenaMaster = servidor + "Database=master;";
                using (SqlConnection con = new SqlConnection(cadenaMaster))
                {
                    con.Open();
                    string verificarBD = "SELECT COUNT(*) FROM sys.databases WHERE name = 'MECANICA_INDUSTRIAL'";
                    SqlCommand cmd = new SqlCommand(verificarBD, con);
                    int existe = (int)cmd.ExecuteScalar();

                    if (existe == 0)
                    {
                        DialogResult resultado = MessageBox.Show(
                            "No se encontró la base de datos MECANICA_INDUSTRIAL.\n¿Desea crearla ahora?",
                            "Base de datos no encontrada",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            CrearBaseDeDatos();
                        }
                        else
                        {
                            MessageBox.Show("No se puede continuar sin la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                    }
                    else
                    {
                        GuardarConfiguracion("SQL=SI", "BD=SI");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar la base de datos: " + ex.Message);
            }
        }

        private void GuardarConfiguracion(string sql, string bd)
        {
            try
            {
                File.WriteAllLines(rutaConfig, new string[] { sql, bd });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar configuración: " + ex.Message);
            }
        }

        private void CrearBaseDeDatos()
        {
            try
            {
                string cadenaMaster = servidor + "Database=master;";
                using (SqlConnection con = new SqlConnection(cadenaMaster))
                {
                    con.Open();

                    // Dividir en comandos separados porque CREATE DATABASE debe ir solo
                    string crearDB = "CREATE DATABASE MECANICA_INDUSTRIAL;";
                    SqlCommand cmdDB = new SqlCommand(crearDB, con);
                    cmdDB.ExecuteNonQuery();

                    // Ahora conectar a la nueva base de datos
                    con.ChangeDatabase("MECANICA_INDUSTRIAL");

                    string script = @"
CREATE TABLE ROL (
    ID_ROL BIGINT PRIMARY KEY,
    NOMBRE_ROL VARCHAR(100),
    DESCRIPCION VARCHAR(255)
);

CREATE TABLE USUARIOS (
    ID_USUARIO BIGINT PRIMARY KEY,
    NOMBRE VARCHAR(100),
    APELLIDO VARCHAR(100),
    CORREO VARCHAR(150) UNIQUE,
    CLAVE VARCHAR(150),
    ID_ROL BIGINT,
    FECHA_REGISTRO DATETIME,
    FOREIGN KEY (ID_ROL) REFERENCES ROL(ID_ROL)
);

CREATE TABLE PROCESOS (
    ID_PROCESOS BIGINT PRIMARY KEY,
    NOMBRE_PROCESO VARCHAR(150),
    DESCRIPCION VARCHAR(255),
    ID_USUARIO BIGINT,
    FOREIGN KEY (ID_USUARIO) REFERENCES USUARIOS(ID_USUARIO)
);

CREATE TABLE CLIENTES (
    ID_CLIENTES BIGINT PRIMARY KEY,
    NOMBRE_CLIENTE VARCHAR(150),
    CORREO VARCHAR(150),
    TELEFONO VARCHAR(50),
    DIRECCION VARCHAR(255),
    FECHA_REGISTRO DATETIME
);

CREATE TABLE SERVICIOS (
    ID_SERVICIOS BIGINT PRIMARY KEY,
    NOMBRE_SERVICIO VARCHAR(150),
    DESCRIPCION VARCHAR(255)
);

CREATE TABLE CONTRATOS (
    ID_CONTRATO BIGINT PRIMARY KEY,
    ID_CLIENTE BIGINT,
    ID_SERVICIO BIGINT,
    FECHA_INICIO DATE,
    FECHA_FIN DATE,
    ESTADO VARCHAR(50),
    FOREIGN KEY (ID_CLIENTE) REFERENCES CLIENTES(ID_CLIENTES),
    FOREIGN KEY (ID_SERVICIO) REFERENCES SERVICIOS(ID_SERVICIOS)
);

CREATE TABLE FACTURAS (
    ID_FACTURA BIGINT PRIMARY KEY,
    ID_CONTRATO BIGINT,
    FECHA_FACTURA DATETIME,
    MONTO_TOTAL DECIMAL(10,2),
    METODO_PAGO VARCHAR(50),
    FOREIGN KEY (ID_CONTRATO) REFERENCES CONTRATOS(ID_CONTRATO)
);

CREATE TABLE PAGOS (
    ID_PAGO BIGINT PRIMARY KEY,
    ID_FACTURA BIGINT,
    FECHA_PAGO DATETIME,
    MONTO_PAGO DECIMAL(10,2),
    ESTADO_PAGO VARCHAR(50),
    FOREIGN KEY (ID_FACTURA) REFERENCES FACTURAS(ID_FACTURA)
);

CREATE TABLE SEGUIMIENTO (
    ID_SEGUIMIENTO BIGINT PRIMARY KEY,
    ID_CONTRATO BIGINT,
    FECHA_SEGUIMIENTO DATETIME,
    DESCRIPCION VARCHAR(255),
    NIVEL_SATISFACTORIO TINYINT,
    FOREIGN KEY (ID_CONTRATO) REFERENCES CONTRATOS(ID_CONTRATO)
);

CREATE TABLE PROVEEDORES (
    ID_PROVEEDOR BIGINT PRIMARY KEY,
    NOMBRE_PROVEEDOR VARCHAR(150),
    TELEFONO VARCHAR(50),
    CORREO VARCHAR(150),
    DIRECCION VARCHAR(255)
);

CREATE TABLE INVENTARIOS (
    ID_INVENTARIO BIGINT PRIMARY KEY,
    NOMBRE_PRODUCTO VARCHAR(150),
    CANTIDAD BIGINT,
    UNIDAD_MEDIDA VARCHAR(50),
    FECHA_INGRESO DATE,
    ESTADO VARCHAR(50),
    ID_PROVEEDOR BIGINT,
    FOREIGN KEY (ID_PROVEEDOR) REFERENCES PROVEEDORES(ID_PROVEEDOR)
);

CREATE TABLE PROYECTOS (
    ID_PROYECTO BIGINT PRIMARY KEY,
    NOMBRE_PROYECTO VARCHAR(150),
    DESCRIPCION VARCHAR(255),
    FECHA_INICIO DATE,
    FECHA_FIN DATE,
    ESTADO VARCHAR(50),
    ID_USUARIO BIGINT,
    FOREIGN KEY (ID_USUARIO) REFERENCES USUARIOS(ID_USUARIO)
);

CREATE TABLE PROYECTO_INVENTARIO (
    ID_PROYECTO_INVENTARIO BIGINT PRIMARY KEY,
    ID_PRODUCTO BIGINT,
    CANTIDAD_USADA BIGINT,
    ID_PROYECTO BIGINT,
    FOREIGN KEY (ID_PRODUCTO) REFERENCES INVENTARIOS(ID_INVENTARIO),
    FOREIGN KEY (ID_PROYECTO) REFERENCES PROYECTOS(ID_PROYECTO)
);

-- Inserciones iniciales
INSERT INTO ROL (ID_ROL, NOMBRE_ROL, DESCRIPCION) VALUES
(1, 'Administrador', 'Acceso total al sistema'),
(2, 'Técnico', 'Encargado de procesos'),
(3, 'Cliente', 'Accede a sus contratos y facturas'),
(4, 'Gerente', 'Supervisa operaciones'),
(5, 'Contador', 'Encargado de finanzas');

INSERT INTO USUARIOS (ID_USUARIO, NOMBRE, APELLIDO, CORREO, CLAVE, ID_ROL, FECHA_REGISTRO) VALUES
(1, 'Carlos', 'Hernandez', 'carlos@example.com', '1234', 1, GETDATE()),
(2, 'Ana', 'Martinez', 'ana@example.com', 'abcd', 2, GETDATE()),
(3, 'Luis', 'Perez', 'luis@example.com', 'pass1', 2, GETDATE()),
(4, 'Maria', 'Lopez', 'maria@example.com', 'pass2', 3, GETDATE()),
(5, 'Jose', 'Sanchez', 'jose@example.com', 'pass3', 4, GETDATE());


INSERT INTO PROCESOS (ID_PROCESOS, NOMBRE_PROCESO, DESCRIPCION, ID_USUARIO) VALUES
(1, 'Soldadura', 'Proceso de unión de piezas metálicas', 2),
(2, 'Mantenimiento', 'Mantenimiento preventivo de maquinaria', 3),
(3, 'Pintura', 'Aplicación de recubrimientos industriales', 2),
(4, 'Torneado', 'Fabricación de piezas cilíndricas', 3),
(5, 'Revisión', 'Inspección de equipos terminados', 2);

INSERT INTO CLIENTES (ID_CLIENTES, NOMBRE_CLIENTE, CORREO, TELEFONO, DIRECCION, FECHA_REGISTRO) VALUES
(1, 'Juan Perez', 'juan@example.com', '99998888', 'Choluteca', GETDATE()),
(2, 'Pedro Gomez', 'pedro@example.com', '88887777', 'Tegucigalpa', GETDATE()),
(3, 'Sofia Diaz', 'sofia@example.com', '97776666', 'San Pedro Sula', GETDATE()),
(4, 'Andrea Ruiz', 'andrea@example.com', '93334444', 'La Ceiba', GETDATE()),
(5, 'Ricardo Castro', 'ricardo@example.com', '92221111', 'Comayagua', GETDATE());

INSERT INTO SERVICIOS (ID_SERVICIOS, NOMBRE_SERVICIO, DESCRIPCION) VALUES
(1, 'Mantenimiento Industrial', 'Revisión y reparación de maquinaria'),
(2, 'Reparación Eléctrica', 'Servicios eléctricos industriales'),
(3, 'Calibración de Equipos', 'Ajuste de precisión en equipos'),
(4, 'Reparación Hidráulica', 'Servicio de sistemas hidráulicos'),
(5, 'Pintura Industrial', 'Pintura protectora en maquinaria');

INSERT INTO CONTRATOS (ID_CONTRATO, ID_CLIENTE, ID_SERVICIO, FECHA_INICIO, FECHA_FIN, ESTADO) VALUES
(1, 1, 1, '2025-01-01', '2025-06-30', 'Activo'),
(2, 2, 2, '2025-02-01', '2025-07-31', 'Activo'),
(3, 3, 3, '2025-03-01', '2025-08-30', 'Pendiente'),
(4, 4, 4, '2025-04-01', '2025-09-30', 'Finalizado'),
(5, 5, 5, '2025-05-01', '2025-10-31', 'Activo');

INSERT INTO FACTURAS (ID_FACTURA, ID_CONTRATO, FECHA_FACTURA, MONTO_TOTAL, METODO_PAGO) VALUES
(1, 1, GETDATE(), 1500.00, 'Efectivo'),
(2, 2, GETDATE(), 2500.00, 'Transferencia'),
(3, 3, GETDATE(), 3500.00, 'Tarjeta'),
(4, 4, GETDATE(), 4500.00, 'Cheque'),
(5, 5, GETDATE(), 5500.00, 'Efectivo');

INSERT INTO PAGOS (ID_PAGO, ID_FACTURA, FECHA_PAGO, MONTO_PAGO, ESTADO_PAGO) VALUES
(1, 1, GETDATE(), 1500.00, 'Completado'),
(2, 2, GETDATE(), 1000.00, 'Pendiente'),
(3, 3, GETDATE(), 3500.00, 'Completado'),
(4, 4, GETDATE(), 2000.00, 'Parcial'),
(5, 5, GETDATE(), 5500.00, 'Completado');

INSERT INTO SEGUIMIENTO (ID_SEGUIMIENTO, ID_CONTRATO, FECHA_SEGUIMIENTO, DESCRIPCION, NIVEL_SATISFACTORIO) VALUES
(1, 1, GETDATE(), 'Cliente satisfecho con el servicio', 5),
(2, 2, GETDATE(), 'Cliente solicita mejoras', 3),
(3, 3, GETDATE(), 'Pendiente revisión final', 2),
(4, 4, GETDATE(), 'Contrato finalizado correctamente', 4),
(5, 5, GETDATE(), 'Cliente muy satisfecho', 5);

INSERT INTO PROVEEDORES (ID_PROVEEDOR, NOMBRE_PROVEEDOR, TELEFONO, CORREO, DIRECCION) VALUES
(1, 'Proveedor A', '98765432', 'provA@example.com', 'Tegucigalpa'),
(2, 'Proveedor B', '97654321', 'provB@example.com', 'San Pedro Sula'),
(3, 'Proveedor C', '96543210', 'provC@example.com', 'Choluteca'),
(4, 'Proveedor D', '95432109', 'provD@example.com', 'La Ceiba'),
(5, 'Proveedor E', '94321098', 'provE@example.com', 'Comayagua');

INSERT INTO INVENTARIOS (ID_INVENTARIO, NOMBRE_PRODUCTO, CANTIDAD, UNIDAD_MEDIDA, FECHA_INGRESO, ESTADO, ID_PROVEEDOR) VALUES
(1, 'Aceite Industrial', 100, 'Litros', '2025-01-10', 'Disponible', 1),
(2, 'Motor Eléctrico', 10, 'Unidades', '2025-02-05', 'Disponible', 2),
(3, 'Pistón Hidráulico', 20, 'Unidades', '2025-03-01', 'Agotado', 3),
(4, 'Pintura Epóxica', 50, 'Galones', '2025-04-15', 'Disponible', 4),
(5, 'Tornillos de Acero', 500, 'Unidades', '2025-05-20', 'Disponible', 5);

INSERT INTO PROYECTOS (ID_PROYECTO, NOMBRE_PROYECTO, DESCRIPCION, FECHA_INICIO, FECHA_FIN, ESTADO, ID_USUARIO) VALUES
(1, 'Proyecto Alfa', 'Instalación de maquinaria', '2025-01-01', '2025-06-01', 'En curso', 2),
(2, 'Proyecto Beta', 'Reparación planta eléctrica', '2025-02-01', '2025-07-01', 'Pendiente', 3),
(3, 'Proyecto Gamma', 'Mantenimiento hidráulico', '2025-03-01', '2025-08-01', 'En curso', 2),
(4, 'Proyecto Delta', 'Pintura industrial', '2025-04-01', '2025-09-01', 'Finalizado', 3),
(5, 'Proyecto Épsilon', 'Modernización de equipos', '2025-05-01', '2025-10-01', 'En curso', 2);

INSERT INTO PROYECTO_INVENTARIO (ID_PROYECTO_INVENTARIO, ID_PRODUCTO, CANTIDAD_USADA, ID_PROYECTO) VALUES
(1, 1, 20, 1),
(2, 2, 2, 2),
(3, 3, 5, 3),
(4, 4, 10, 4),
(5, 5, 50, 5);
";

                    SqlCommand cmd = new SqlCommand(script, con);
                    cmd.ExecuteNonQuery();

                    GuardarConfiguracion("SQL=SI", "BD=SI");

                    MessageBox.Show("✅ Base de datos MECANICA_INDUSTRIAL creada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al crear la base de datos: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // PASO 1: Detectar el servidor SQL automáticamente
                servidor = ObtenerServidorSQL();

                if (servidor == null)
                {
                    Application.Exit();
                    return;
                }

                // PASO 2: Verificar si existe la base de datos
                VerificarBaseDeDatos();

                // PASO 3: Intentar conectar a la base de datos
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    MessageBox.Show("✅ Conexión exitosa con la base de datos MECANICA_INDUSTRIAL.",
                        "Conexión verificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al conectar con la base de datos:\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Centrar controles
            int centerX = (this.ClientSize.Width - barratitulo.Width) / 2;
            int centerY = (this.ClientSize.Height - barratitulo.Height) / 2;
            barratitulo.Location = new Point(centerX, centerY);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text.Trim();
            string contra = txtcontra.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contra))
            {
                MessageBox.Show("Debe ingresar usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = "SELECT COUNT(*) FROM USUARIOS WHERE NOMBRE = @nombre AND CLAVE = @clave";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@clave", contra);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Inicio de sesión exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Menu frmMenu = new Menu();
                        frmMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos:\n" + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtcontra.Clear();
            txtnombre.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e) { }
        private void txtcontra_TextChanged(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            button1.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            button1.Visible = true;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e) { }
        private void button6_Click(object sender, EventArgs e) { }
    }
}