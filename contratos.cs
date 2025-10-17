using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INICIO
{
    public partial class contratos : Form
    {
        private ConexionBD conexionDB = new ConexionBD();
        private string conexiontionString;

        public contratos()
        {
            InitializeComponent();
            CargarClientes();
            CargarServicios();


        }
        private void CargarClientes()
        {
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string query = "SELECT ID_CLIENTES, NOMBRE_CLIENTE FROM CLIENTES";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbCliente.DataSource = dt;
                    cmbCliente.DisplayMember = "NOMBRE_CLIENTE";
                    cmbCliente.ValueMember = "ID_CLIENTES";
                    cmbCliente.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void CargarServicios()
        {
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string query = "SELECT ID_SERVICIOS, NOMBRE_SERVICIO FROM SERVICIOS";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbServicio.DataSource = dt;
                    cmbServicio.DisplayMember = "NOMBRE_SERVICIO";
                    cmbServicio.ValueMember = "ID_SERVICIOS";
                    cmbServicio.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar servicios: " + ex.Message);
            }
        }

     


        private void ConfigurarFormulario()
        {
            dtpinicio.Format = DateTimePickerFormat.Short;
            dtpfin.Format = DateTimePickerFormat.Short;

            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = true;
        }


        // 🔹 Cargar proyectos desde la BD al ComboBox
       



        private void contratos_Load(object sender, EventArgs e)
        {


            txtIdContrato.Enabled = false; // No permitir editar el ID
            GenerarNuevoId(); // 🔹 Llamar a función que genera el ID automáticamente
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string query = "INSERT INTO CONTRATOS (ID_CONTRATO, ID_CLIENTE, ID_SERVICIO, FECHA_INICIO, FECHA_FIN, ESTADO) " +
                                   "VALUES (@ID_CONTRATO, @ID_CLIENTE, @ID_SERVICIO, @FECHA_INICIO, @FECHA_FIN, @ESTADO)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_CONTRATO", txtIdContrato.Text);
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", cmbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@ID_SERVICIO", cmbServicio.SelectedValue);
                    cmd.Parameters.AddWithValue("@FECHA_INICIO", dtpinicio.Value);
                    cmd.Parameters.AddWithValue("@FECHA_FIN", dtpfin.Value);
                    cmd.Parameters.AddWithValue("@ESTADO", txtestado.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Contrato guardado correctamente.");

                    LimpiarCampos();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar contrato: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            txtIdContrato.Enabled = true;
            cmbCliente.Enabled = true;
            cmbServicio.Enabled = true;
            txtestado.Enabled = true;
            dtpinicio.Enabled = true;
           
            btnGuardar.Enabled = true;
            LimpiarCampos();
        }



        private void LimpiarCampos()
        {
            txtIdContrato.Clear();
            cmbCliente.SelectedIndex = -1;
            cmbServicio.SelectedIndex = -1;
            txtestado.Clear();
            dtpinicio.Value = DateTime.Now;
            dtpfin.Value = DateTime.Now;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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
                string consulta = "SELECT ISNULL(MAX(ID_CONTRATO), 0) + 1 FROM CONTRATOS";
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

                    string consulta = "SELECT ISNULL(MAX(ID_CONTRATO), 0) + 1 FROM CONTRATOS";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    object resultado = cmd.ExecuteScalar();
                    txtIdContrato.Text = (resultado != null) ? resultado.ToString() : "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar ID: " + ex.Message);
                txtIdContrato.Text = "1";
            }
        }

    }
}

