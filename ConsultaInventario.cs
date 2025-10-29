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
    public partial class ConsultaInventario : Form
    {
        public ConsultaInventario()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
               "¿Está seguro que desea salir del sistema de inventario?",
               "Confirmar Salida",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            // Si el usuario presiona "Sí", cerrar el formulario
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CargarInventario()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = "SELECT * FROM INVENTARIOS";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvinventario.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }

        private void ConsultaInventario_Load(object sender, EventArgs e)
        {
            cmbbuscar.Items.Add("ID_INVENTARIO");
            cmbbuscar.Items.Add("NOMBRE_PRODUCTO");
            cmbbuscar.Items.Add("CANTIDAD");
            cmbbuscar.Items.Add("UNIDAD_MEDIDA");
            cmbbuscar.Items.Add("FECHA_INGRESO");
            cmbbuscar.Items.Add("ESTADO");
            cmbbuscar.Items.Add("ID_PROVEEDOR");
            cmbbuscar.SelectedIndex = 0;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            cmbbuscar.SelectedIndex = 0;
            txtdescripcion.Clear();
            dgvinventario.DataSource = null;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columna = cmbbuscar.Text;
            string valor = txtdescripcion.Text.Trim();

            if (string.IsNullOrEmpty(valor))
            {
                MessageBox.Show("Ingrese ID para buscar en inventario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query;

                    if (columna == "Fecha")
                    {
                        query = "SELECT * FROM ID_INVENTARIOS WHERE CONVERT(date, Fecha) = @id";
                    }
                    else
                    {
                        query = $"SELECT * FROM INVENTARIOS WHERE {columna} LIKE '%' + @id + '%'";
                    }

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", valor);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvinventario.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }

        }

    }
}



