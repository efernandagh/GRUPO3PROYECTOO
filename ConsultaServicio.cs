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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace INICIO
{
    public partial class ConsultaServicio : Form
    {
        public ConsultaServicio()
        {
            InitializeComponent();
        }

        private void Salidapagos_Load(object sender, EventArgs e)
        {
            cbmbuscar.Items.Add("ID_SERVICIOS");
            cbmbuscar.Items.Add("NOMBRE_SERVICIO");
            cbmbuscar.Items.Add("DESCRIPCION");
            cbmbuscar.SelectedIndex = 0;
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            // Preguntar si realmente quiere salir
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir de su Consulta de Servicios?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Si el usuario presiona "Sí", cerrar el formulario
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CargarServicio()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = "SELECT * FROM SERVICIOS";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvservicio.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar algunos servicios: " + ex.Message);
            }
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtdescripcion.Clear();
            cbmbuscar.SelectedIndex = 0;
            dgvservicio.DataSource = null;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columna = cbmbuscar.Text;
            string valor = txtdescripcion.Text.Trim();

            if (string.IsNullOrEmpty(valor))
            {
                MessageBox.Show("Ingrese su ID para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = $"SELECT * FROM NOMBRE_SERVICIO WHERE {columna} LIKE '%' + @valor + '%'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@valor", valor);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvservicio.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void cbmbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
