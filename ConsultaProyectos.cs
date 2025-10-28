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

    public partial class ConsultaProyectos : Form
    {
        public ConsultaProyectos()
        {
            InitializeComponent();
        }






        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtbuscar.Clear();
            cbobuscar.SelectedIndex = 0;
            dtvproyectos.DataSource = null;
        }

        private void ConsultaProyectos_Load(object sender, EventArgs e)
        {
            cbobuscar.Items.Add("ID_PROYECTO");
            cbobuscar.Items.Add("NOMBRE_PROYECTO");
            cbobuscar.Items.Add("DESCRIPCION");
            cbobuscar.Items.Add("FECHA_INICIO");
            cbobuscar.Items.Add("FECHA_FIN");
            cbobuscar.Items.Add("ESTADO");
            cbobuscar.Items.Add("ID_USUARIO");
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
        private void CargarProyectos()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = "SELECT * FROM PROYECTOS";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtvproyectos.DataSource = dt;
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
                        query = "SELECT * FROM PROYECTOS WHERE CONVERT(date, Fecha) = @valor";
                    }
                    else
                    {
                        query = $"SELECT * FROM PROYECTOS WHERE {columna} LIKE '%' + @valor + '%'";
                    }

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@valor", valor);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtvproyectos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {
            txtbuscar.Clear();
            cbobuscar.SelectedIndex = 0;
            dtvproyectos.DataSource = null;
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
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
                        query = "SELECT * FROM PROYECTOS WHERE CONVERT(date, Fecha) = @valor";
                    }
                    else
                    {
                        query = $"SELECT * FROM PROYECTOS WHERE {columna} LIKE '%' + @valor + '%'";
                    }

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@valor", valor);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtvproyectos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}