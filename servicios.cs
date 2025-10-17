using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace INICIO
{
    public partial class servicios : Form
    {
        private ConexionBD conexionDB = new ConexionBD(); // Instancia de la clase de conexión
        private string conexion;
        private string conexiontionString;

        public servicios()
        {
            InitializeComponent();
        }
        private SqlConnection Conectar()
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
                string query = "SELECT NOMBRE_SERVICIO FROM SERVICIOS";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

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

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string query = "INSERT INTO SERVICIOS (ID_SERVICIOS, NOMBRE_SERVICIO, DESCRIPCION) VALUES (@id, @nombre, @descripcion)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtidservicio.Text);
                cmd.Parameters.AddWithValue("@nombre", txtnombreser.Text);
                cmd.Parameters.AddWithValue("@descripcion", txtdesc.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Servicio guardado correctamente.");
                con.Close();
            }
        }

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





        private void LimpiarCampos()
        {
            txtidservicio.Clear();
            txtnombreser.Text = "";
            txtdesc.Clear();
        }

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
        // <<-- Asegúrate de que este método exista y tenga este nombre EXACTO
        private void GenerarNuevoId()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {

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
    }
}

