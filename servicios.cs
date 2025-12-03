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
    public partial class servicios : Form // Clase parcial para el formulario de servicios
    {
        private ConexionBD conexionDB = new ConexionBD(); // Instancia de la clase de conexión
        private string conexion; // Cadena de conexión a la base de datos
        private string conexiontionString;


        
        public servicios() // Constructor del formulario
        {
            InitializeComponent();
        }
        private SqlConnection Conectar() // Función para conectar a la base de datos
        {
            SqlConnection conn = new SqlConnection(conexion);
            conn.Open();
            return conn;
        }

        // 🔸 Cargar ComboBox con los servicios al iniciar
        private void servicios_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conectar()) 
            {
                // Cargar los nombres de los servicios en el ComboBox
                string query = "SELECT NOMBRE_SERVICIO FROM SERVICIOS";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                // Limpiar los ítems actuales
                while (reader.Read()) 
                {
                    txtnombreser.Items.Add(reader["NOMBRE_SERVICIO"].ToString());
                }

                conn.Close();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        // Salir del formulario
        private void button2_Click(object sender, EventArgs e)
        {// Preguntar si está seguro de salir
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?",
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void txtnombredelservicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtdesc_TextChanged(object sender, EventArgs e)
        {

        }

        // Guardar nuevo servicio en la base de datos
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion()) 
            {
                string query = "INSERT INTO SERVICIOS (ID_SERVICIOS, NOMBRE_SERVICIO, DESCRIPCION) VALUES (@id, @nombre, @descripcion)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtidservicio.Text);
                cmd.Parameters.AddWithValue("@nombre", txtnombreser.Text);
                cmd.Parameters.AddWithValue("@descripcion", txtdesc.Text);


                MessageBox.Show("Servicio guardado correctamente.");
                con.Close();
            }
        }


        // Limpiar formulario para nuevo servicio
        private void btneditar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            txtidservicio.Clear();
            txtnombreser.Text = "";
            txtdesc.Clear();


            // Poner el foco en el primer campo
            txtidservicio.Focus();

            MessageBox.Show("Formulario limpiado", "Limpiar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        // ✅ Función para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtidservicio.Clear();
            txtnombreser.Text = "";
            txtdesc.Clear();
        }

        // 🔹 Evento Load del formulario para inicializar componentes
        private void servicios_Load_1(object sender, EventArgs e)
        {
            txtidservicio.Enabled = false; // No permitir editar el ID
            GenerarNuevoId(); // 🔹 Llamar a función que genera el ID automáticamente
        }
        // ✅ Función para generar el siguiente ID automáticamente
        private int ObtenerSiguienteIdUsuario() 
        {
            int siguienteId = 1;
            
            using (SqlConnection conexion = new SqlConnection(conexiontionString)) 
            {
                conexion.Open();
                string consulta = "SELECT ISNULL(MAX(ID_SERVICIOS), 0) + 1 FROM SERVICIOS";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                siguienteId = Convert.ToInt32(comando.ExecuteScalar());
            }

            return siguienteId;
        }

        // 🔹 Función para generar un nuevo ID de servicio
        private void GenerarNuevoId()
        {
            try
            {
                // Conectar a la base de datos y obtener el siguiente ID
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    // Consulta SQL para obtener el siguiente ID disponible
                    string consulta = "SELECT ISNULL(MAX(ID_USUARIO), 0) + 1 FROM USUARIOS";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    object resultado = cmd.ExecuteScalar();
                    txtidservicio.Text = (resultado != null) ? resultado.ToString() : "1";
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("❌ Error al generar ID: " + ex.Message);
                txtidservicio.Text = "1";
            }
        }

        // Abrir el manual de usuario en PDF
        private void btnayuda_Click(object sender, EventArgs e)
        {
            // Ruta del PDF en la carpeta del ejecutable
            string rutaPdf = Path.Combine(Application.StartupPath, "Manual de Servicios.pdf");

            if (File.Exists(rutaPdf))
            {
                try
                {
                    // Abrir el PDF con la aplicación predeterminada del sistema
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = rutaPdf,
                        UseShellExecute = true
                    };
                    Process.Start(psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo abrir el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Notificar si hay un error al abrir el PDF
                }
            }
            else 
            {
                MessageBox.Show("No se encontró el archivo PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Notificar si no se encuentra el archivo
            }
        }
    }
}

