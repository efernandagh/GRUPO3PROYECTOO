using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INICIO
{
    public partial class inventario : Form
    {
        //Instancia para manejar la conexión
        private ConexionBD conexionDB = new ConexionBD();
        private string conexiontionString;

        
        //Carga los componentes del formulario
        public inventario()
        {
            InitializeComponent();
        }
        // ✅ Cargar valores únicos de UNIDAD_MEDIDA en el ComboBox
        private void CargarUnidades()
        {
            // Realiza la carga de unidades de medida desde la base de datos
            try
            {
                cmbunidad.Items.Clear(); // Limpiar por si se vuelve a cargar

                using (SqlConnection conn = Conectar())
                {
                    string query = "SELECT DISTINCT UNIDAD_MEDIDA FROM INVENTARIOS WHERE UNIDAD_MEDIDA IS NOT NULL";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbunidad.Items.Add(reader["UNIDAD_MEDIDA"].ToString()); // Agregar solo valores únicos
                    }
                }

                if (cmbunidad.Items.Count == 0) 
                {
                    MessageBox.Show("No se encontraron unidades de medida en la tabla INVENTARIOS.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar unidades de medida: " + ex.Message);
            }
        }

        // 🔸 Función para abrir la conexión a la base de datos
        private SqlConnection AbrirConexion()
        {
            return ConexionBD.ObtenerConexion();
        }
        // 🔸 Cargar ComboBox con los servicios al iniciar
        private void servicios_Load(object sender, EventArgs e)
        {
            // Cargar unidades de medida en el ComboBox al cargar el formulario

            using (SqlConnection conn = Conectar())
            {
                string query = "SELECT UNIDAD_MEDIDA FROM INVENTARIOS";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) 
                {
                    cmbunidad.Items.Add(reader["UNIDAD_MEDIDA"].ToString());
                }

                conn.Close();
            }
        }

        //Centraliza el acceso a la base de datos y permite reutilización y mantenimiento más fácil
        //🔸 Función para abrir la conexión a la base de datos
        private SqlConnection Conectar()
        {
            return ConexionBD.ObtenerConexion();
        }

        // Configuración inicial al cargar el formulario
        private void inventario_Load(object sender, EventArgs e)
        {
            txtidinventario.Enabled = false;
            GenerarNuevoId();
            CargarUnidades();
        }

        // Guarda un nuevo inventario en la base de datos
        private void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conectar())
            {
                string query = "INSERT INTO INVENTARIOS (ID_INVENTARIO, NOMBRE_PRODUCTO, CANTIDAD, UNIDAD_MEDIDA, FECHA_INGRESO, ESTADO, ID_PROVEEDOR) VALUES (@id, @nombre, @cantidad, @unidad, @fecha, @estado, @ID_PROVEEDOR)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt64(txtidinventario.Text));
                cmd.Parameters.AddWithValue("@nombre", txtnombrepro.Text);
                cmd.Parameters.AddWithValue("@cantidad", txtcantidad.Text);
                cmd.Parameters.AddWithValue("@unidad", cmbunidad.Text);
                cmd.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dtpfecha.Text));
                cmd.Parameters.AddWithValue("@estado", txtestado.Text);
                cmd.Parameters.AddWithValue("@ID_PROVEEDOR", Convert.ToInt64(txtidpro.Text));

                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inventario guardado correctamente.");
                conn.Close();
            }
        }

        // Limpia todos los campos del formulario para editar un inventario existente
        private void btneditar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            txtidinventario.Clear();
            txtnombrepro.Text = "";
            txtcantidad.Clear();
            cmbunidad.Items.Clear();
            dtpfecha.Text = "";
            txtestado.Clear();
            txtidpro.Clear();


            // Poner el foco en el primer campo
            txtidinventario.Focus();

            MessageBox.Show("Formulario limpiado", "Limpiar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // Función para limpiar todos los campos del formulario 
        private void LimpiarCampos()
        {
            txtidinventario.Clear();
            txtnombrepro.Text = "";
            txtcantidad.Clear();
            cmbunidad.Items.Clear();
            dtpfecha.Text = "";
            txtestado.Clear();
            txtidpro.Clear();

        }

        // Limpia los campos al hacer clic en el botón "Limpiar"
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Cierra el formulario al hacer clic en el botón "Cancelar"
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Guarda un nuevo inventario en la base de datos al hacer clic en el botón "Nuevo"
        private void btnnuevo_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = Conectar())
                {
                    string query = @"INSERT INTO INVENTARIOS 
                    (ID_INVENTARIO, NOMBRE_PRODUCTO, CANTIDAD, UNIDAD_MEDIDA, FECHA_INGRESO, ESTADO, ID_PROVEEDOR) 
                    VALUES (@id, @nombre, @cantidad, @unidad, @fecha, @estado, @ID_PROVEEDOR)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt64(txtidinventario.Text));
                    cmd.Parameters.AddWithValue("@nombre", txtnombrepro.Text);
                    cmd.Parameters.AddWithValue("@cantidad", txtcantidad.Text);
                    cmd.Parameters.AddWithValue("@unidad", cmbunidad.Text);
                    cmd.Parameters.AddWithValue("@fecha", dtpfecha.Value);
                    cmd.Parameters.AddWithValue("@estado", txtestado.Text);
                    cmd.Parameters.AddWithValue("@ID_PROVEEDOR", Convert.ToInt64(txtidpro.Text));

                    cmd.ExecuteNonQuery();
                }
                
                MessageBox.Show("✅ Inventario guardado correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar inventario: " + ex.Message);
            }
        }

        // ✅ Función para generar el siguiente ID automáticamente
        private int ObtenerSiguienteIdUsuario()
        {
            int siguienteId = 1;

            using (SqlConnection conexion = new SqlConnection(conexiontionString))
            {
                conexion.Open();
                string consulta = "SELECT ISNULL(MAX(ID_INVENTARIO), 0) + 1 FROM INVENTARIOS";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                siguienteId = Convert.ToInt32(comando.ExecuteScalar());
            }

            return siguienteId;
        }

        // ✅ Genera un nuevo ID para el inventario al cargar el formulario
        private void GenerarNuevoId()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion()) // Abrir conexión
                {

                    string consulta = "SELECT ISNULL(MAX(ID_INVENTARIO), 0) + 1 FROM INVENTARIOS";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    object resultado = cmd.ExecuteScalar();
                    txtidinventario.Text = (resultado != null) ? resultado.ToString() : "1";
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show("❌ Error al generar ID: " + ex.Message); // Mostrar mensaje de error
                txtidinventario.Text = "1";
            }
        }

      
        private void label7_Click(object sender, EventArgs e)
        {

        }

        // Abre el manual de inventario en PDF al hacer clic en el botón de ayuda
        private void btnayuda_Click(object sender, EventArgs e)
        {
            // Ruta del PDF en la carpeta del ejecutable
            string rutaPdf = Path.Combine(Application.StartupPath, "Manual d Inventario.pdf");

            if (File.Exists(rutaPdf))
            {
                // Abre el PDF con la aplicación predeterminada del sistema
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = rutaPdf,
                        UseShellExecute = true
                    };
                    Process.Start(psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo abrir el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
    