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

        private void InicializarCombos()
        {
            try
            {
                cmbtabla.Items.Clear();
                cmbtabla.Items.Add("INVENTARIOS");
                cmbtabla.Items.Add("PROVEEDORES");

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
                    dgvinventario.DataSource = dt;
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
            cmbbuscar.Items.Clear();

            switch (tabla)
            {
                case "INVENTARIOS":
                    cmbbuscar.Items.AddRange(new string[]
                    {
                        "ID_INVENTARIO",
                        "NOMBRE_PRODUCTO",
                        "CANTIDAD",
                        "UNIDAD_MEDIDA",
                        "FECHA_INGRESO",
                        "ESTADO",
                        "ID_PROVEEDOR"
                    });
                    break;

                case "PROVEEDORES":
                    cmbbuscar.Items.AddRange(new string[]
                    {
                        "ID_PROVEEDOR",
                        "NOMBRE_PROVEEDOR",
                        "TELEFONO",
                        "CORREO",
                        "DIRECCION"
                    });
                    break;
            }

            if (cmbbuscar.Items.Count > 0)
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
            string tabla = cmbtabla.Text;
            string columna = cmbbuscar.Text;
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
                    dgvinventario.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void ConsultaInventario_Load_1(object sender, EventArgs e)
        {

            InicializarCombos();
        }

        private void cmbtabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tabla = cmbtabla.Text;
            CargarColumnas(tabla);
            CargarDatos(tabla);
        }

        private void cmbbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}



