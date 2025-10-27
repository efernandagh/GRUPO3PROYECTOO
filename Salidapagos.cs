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

    public partial class Salidapagos : Form
    {
        public Salidapagos()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {



        }





        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtbuscar.Clear();
            cbobuscar.SelectedIndex = 0;
            dtvpagos.DataSource = null;
        }

        private void Salidapagos_Load(object sender, EventArgs e)
        {
            cbobuscar.Items.Add("ID_PAGO");
            cbobuscar.Items.Add("ID_FACTURA");
            cbobuscar.Items.Add("FECHA_PAGO");
            cbobuscar.Items.Add("Monto_PAGO");
            cbobuscar.Items.Add("ESTADO_PAGO");
            cbobuscar.SelectedIndex = 0;
        }

        private void btnsalir_Click(object sender, EventArgs e)
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
        
        // 🔹 Cargar todos los registros
        private void CargarPagos()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = "SELECT * FROM Pagos";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtvpagos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pagos: " + ex.Message);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columna = cbobuscar.Text;
            string valor = txtbuscar.Text.Trim();

            if (string.IsNullOrEmpty(valor))
            {
                MessageBox.Show("Ingrese un valor para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query;

                    if (columna == "Fecha")
                    {
                        query = "SELECT * FROM PAGOS WHERE CONVERT(date, Fecha) = @valor";
                    }
                    else
                    {
                        query = $"SELECT * FROM PAGOS WHERE {columna} LIKE '%' + @valor + '%'";
                    }

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@valor", valor);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtvpagos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void dtvpagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbobuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
