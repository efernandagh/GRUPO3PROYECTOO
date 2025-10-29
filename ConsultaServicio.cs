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
        private void InicializarCombos()
        {
            try
            {
                cmbtabla.Items.Clear();
                cmbtabla.Items.Add("CLIENTES");
                cmbtabla.Items.Add("SERVICIOS");

                if (cmbtabla.Items.Count > 0)
                {
                    cmbtabla.SelectedIndex = 0;
                    CargarColumnas(cmbtabla.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar combos: " + ex.Message);
            }
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

        // 🔹 Cargar todos los datos de la tabla seleccionada
        private void CargarDatos(string tabla)
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = $"SELECT * FROM {tabla}";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvservicio.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
        // 🔹 Cargar columnas según la tabla seleccionada
        private void CargarColumnas(string tabla)
        {
            cbmbuscar.Items.Clear();

            if (tabla == "CLIENTES")
            {
                cbmbuscar.Items.AddRange(new string[]
                {
                    "ID_CLIENTES",
                    "NOMBRE_CLIENTE",
                    "CORREO",
                    "TELEFONO",
                    "DIRECCION",
                    "FECHA_REGISTRO"
                });
            }
            else if (tabla == "SERVICIOS")
            {
                cbmbuscar.Items.AddRange(new string[]
                {
                    "ID_SERVICIOS",
                    "NOMBRE_SERVICIO",
                    "DESCRIPCION"
                });
            }

            if (cbmbuscar.Items.Count > 0)
                cbmbuscar.SelectedIndex = 0;
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtdescripcion.Clear();
            cbmbuscar.SelectedIndex = 0;
            dgvservicio.DataSource = null;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string tabla = cmbtabla.Text;
            string columna = cbmbuscar.Text;
            string valor = txtdescripcion.Text.Trim();

            if (string.IsNullOrEmpty(valor))
            {
                MessageBox.Show("Ingrese un valor para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = $"SELECT * FROM {tabla} WHERE {columna} LIKE '%' + @valor + '%'";
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

        private void ConsultaServicio_Load(object sender, EventArgs e)
        {

            InicializarCombos();
        }

        private void cmbbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tabla = cmbtabla.SelectedItem.ToString();
            CargarColumnas(tabla);
            CargarDatos(tabla);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
