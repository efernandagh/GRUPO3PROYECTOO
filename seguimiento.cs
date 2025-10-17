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

    public partial class seguimiento : Form
    {
        public seguimiento()
        {
            InitializeComponent();
            Desactivar();
        }
        private ConexionBD conexionDB = new ConexionBD();
        private string conexiontionString;


        private void seguimiento_Load(object sender, EventArgs e)
        {

            txtSeguimiento.Enabled = false; // No permitir editar el ID
            GenerarNuevoId(); // 🔹 Llamar a función que genera el ID automáticamente
            // 🔹 Cargar usuarios al iniciar el formulario
            try
            {


                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {


                    string query = "SELECT ID_CONTRATO FROM CONTRATOS";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbContrato.Items.Clear();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("ℹ️ No se encontraron usuarios en la base de datos.",
                                        "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    while (reader.Read())
                    {
                        cbContrato.Items.Add(reader["ID_CONTRATO"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("❌ Error SQL al cargar usuarios:\n" + ex.Message,
                                "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error general al cargar usuarios:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Desactivar()
        {



        }
        public void Activar()
        {
            txtSeguimiento.Enabled = true;
            cbContrato.Enabled = true;
            txtDescripcion.Enabled = true;
            dtpFecha.Enabled = true;
            txtNivel.Enabled = true;
            btnGuardar.Enabled = true;
            btnLimpiar.Enabled = true;


        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Activar();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Preguntar si realmente quiere salir
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir del sistema de facturas?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Si el usuario presiona "Sí", cerrar el formulario
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private ConexionBD conexionBD = new ConexionBD(); // Instancia de la clase de conexión

        public void Almacenar()
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                try
                {


                    string sql = "INSERT INTO SEGUIMIENTO (ID_SEGUIMIENTO, ID_CONTRATO, FECHA_SEGUIMIENTO, DESCRIPCION, NIVEL_SATISFACTORIO) " +
                                 "VALUES (@ID_SEGUIMIENTO, @ID_CONTRATO, @FECHA_SEGUIMIENTO, @DESCRIPCION, @NIVEL_SATISFACTORIO)";

                    using (SqlCommand command = new SqlCommand(sql, conexion))
                    {
                        command.Parameters.AddWithValue("@ID_SEGUIMIENTO", txtSeguimiento.Text);
                        command.Parameters.AddWithValue("@ID_CONTRATO", Convert.ToInt32(cbContrato.SelectedItem));
                        command.Parameters.AddWithValue("@FECHA_SEGUIMIENTO", DateTime.Parse(dtpFecha.Text));
                        command.Parameters.AddWithValue("@DESCRIPCION", txtDescripcion.Text);
                        command.Parameters.AddWithValue("@NIVEL_SATISFACTORIO", txtNivel.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Proyecto agregado exitosamente.",
                        "Hola SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Almacenar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        // ✅ Función para generar el siguiente ID automáticamente
        private int ObtenerSiguienteIdUsuario()
        {
            int siguienteId = 1;

            using (SqlConnection conexion = new SqlConnection(conexiontionString))
            {
                conexion.Open();
                string consulta = "SELECT ISNULL(MAX(ID_SEGUIMIENTO), 0) + 1 FROM SEGUIMIENTO";
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

                    string consulta = "SELECT ISNULL(MAX(ID_SEGUIMIENTO), 0) + 1 FROM SEGUIMIENTO";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    object resultado = cmd.ExecuteScalar();
                    txtSeguimiento.Text = (resultado != null) ? resultado.ToString() : "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar ID: " + ex.Message);
                txtSeguimiento.Text = "1";
            }
        }
    }
}
