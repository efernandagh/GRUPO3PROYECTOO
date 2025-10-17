using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace INICIO
{
    public partial class Form1 : Form

    {
        private string servidor = "Server=DESKTOP-8QJ2O4S\\ENIAGOMEZ;Integrated Security=True;TrustServerCertificate=True;";

        private ConexionBD conexionDB = new ConexionBD();

        public Form1()
        {
            InitializeComponent();

            PreguntarSQL();

        }

        private void PreguntarSQL()
        {
            DialogResult tieneSQL = MessageBox.Show(
                "¿Tiene instalado SQL Server en su equipo?",
                "Verificación SQL Server",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (tieneSQL == DialogResult.No)
            {
                MessageBox.Show(
                    "Debe instalar SQL Server antes de continuar.\nEl programa se cerrará.",
                    "Requisito necesario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Application.Exit();
                return;
            }

            // Si tiene SQL, pasamos a verificar la base de datos
            VerificarBaseDeDatos();
        }

        private void VerificarBaseDeDatos()
        {
            DialogResult tieneBD = MessageBox.Show(
                "¿Ya tiene creada la base de datos MECANICA_INDUSTRIAL?",
                "Verificación Base de Datos",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (tieneBD == DialogResult.No)
            {
                DialogResult crearBD = MessageBox.Show(
                    "¿Desea crear la base de datos automáticamente?",
                    "Crear Base de Datos",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (crearBD == DialogResult.Yes)
                {
                    CrearBaseDeDatos();
                }
                else
                {
                    MessageBox.Show(
                        "No se puede continuar sin la base de datos.\nEl programa se cerrará.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Perfecto ? Puede iniciar sesión.", "Confirmación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    string script = @"
                    CREATE DATABASE MECANICA_INDUSTRIAL;
                    USE MECANICA_INDUSTRIAL;

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

                    INSERT INTO ROL (ID_ROL, NOMBRE_ROL, DESCRIPCION) VALUES
                    (1, 'Administrador', 'Acceso total al sistema'),
                    (2, 'Técnico', 'Encargado de procesos'),
                    (3, 'Cliente', 'Accede a sus contratos y facturas');

                    CREATE TABLE CLIENTES (
                        ID_CLIENTES BIGINT PRIMARY KEY,
                        NOMBRE_CLIENTE VARCHAR(100),
                        CORREO VARCHAR(100),
                        TELEFONO VARCHAR(20),
                        DIRECCION VARCHAR(255),
                        FECHA_REGISTRO DATETIME
                    );
                    ";

                    SqlCommand cmd = new SqlCommand(script, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("? Base de datos MECANICA_INDUSTRIAL creada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("? Error al crear la base de datos: " + ex.Message);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // Centrar todo el grupo de controles
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

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
