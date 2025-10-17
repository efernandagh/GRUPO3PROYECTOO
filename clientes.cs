using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace INICIO
{
    public partial class clientes : Form
    {
        private string conexiontionString;
        string conexion = "Server=DESKTOP-FT2QP2U\\SQLEXPRESS;Database=MECANICA_INDUSTRIAL;Integrated Security=True;TrustServerCertificate=True;";

        public clientes()
        {
            InitializeComponent();
        }

        private SqlConnection CrearConexion()
        {
            return new SqlConnection(conexion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conectar())
            {
                string query = "INSERT INTO CLIENTES (ID_CLIENTES, NOMBRE_CLIENTE, CORREO, TELEFONO, DIRECCION, FECHA_REGISTRO) VALUES (@id, @nombre, @correo, @telefono, @direccion, @fecha)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id ", Convert.ToInt64(txtIdcliente.Text));
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
                cmd.Parameters.AddWithValue("@correo", txtcorreo.Text);
                cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text);
                cmd.Parameters.AddWithValue("@telefono", txttelefono.Text);
                cmd.Parameters.AddWithValue("@fecha", dtpfecharegistro.Value);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente guardado correctamente.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }

            }
        }

        private SqlConnection Conectar()
        {
            return new SqlConnection(conexion);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clientes_Load(object sender, EventArgs e)
        {
            txtIdcliente.Enabled = false; // No permitir editar el ID
            GenerarNuevoId(); // 🔹 Llamar a función que genera el ID automáticamente
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtIdcliente.Clear();
            txtnombre.Clear();
            txttelefono.Clear();
            txtcorreo.Clear();
            txtdireccion.Clear();
            dtpfecharegistro.Value = DateTime.Now;


        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ✅ Función para generar el siguiente ID automáticamente
        private int ObtenerSiguienteIdUsuario()
        {
            int siguienteId = 1;

            using (SqlConnection conexion = new SqlConnection(conexiontionString))
            {
                conexion.Open();
                string consulta = "SELECT ISNULL(MAX(ID_CLIENTES), 0) + 1 FROM CLIENTES";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                siguienteId = Convert.ToInt32(comando.ExecuteScalar());
            }

            return siguienteId;
        }
        private void GenerarNuevoId()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {

                    string consulta = "SELECT ISNULL(MAX(ID_CLIENTES), 0) + 1 FROM CLIENTES";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    object resultado = cmd.ExecuteScalar();
                    txtIdcliente.Text = (resultado != null) ? resultado.ToString() : "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar ID: " + ex.Message);
                txtIdcliente.Text = "1";
            }
        }
    }
}


