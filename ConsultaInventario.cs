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

        private void CargarDescripcion()
        {
            cmbdescripcion.Items.Clear();

            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string campo = cmbbuscar.SelectedItem.ToString();
                string query = $"SELECT DISTINCT {campo} FROM PAGOS";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cmbdescripcion.Items.Add(dr[0].ToString());
                }
            }

            if (cmbdescripcion.Items.Count > 0)
                cmbdescripcion.SelectedIndex = 0;
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

        private void CargarDescripcion(string tabla, string columna)
        {
            cmbdescripcion.Items.Clear();

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = $"SELECT DISTINCT {columna} FROM {tabla}";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        cmbdescripcion.Items.Add(dr[columna].ToString());
                    }

                    dr.Close();

                    if (cmbdescripcion.Items.Count > 0)
                        cmbdescripcion.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar descripciones: " + ex.Message);
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
            cmbdescripcion.SelectedIndex = 0;
            dgvinventario.DataSource = null;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string tabla = cmbtabla.Text;
            string columna = cmbbuscar.Text;
            string valor = cmbdescripcion.Text.Trim();

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
            string tablaSeleccionada = cmbtabla.Text;
            CargarColumnas(tablaSeleccionada);

            // Limpiar combos dependientes
            cmbdescripcion.Items.Clear();
            cmbdescripcion.Text = "";
        }

        private void cmbbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbdescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tabla = cmbtabla.Text;
            string columna = cmbbuscar.Text;
            string valor = cmbdescripcion.Text;

            if (string.IsNullOrEmpty(valor))
                return;

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = $"SELECT * FROM {tabla} WHERE {columna} = @valor";
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
                MessageBox.Show("Error al buscar en Inventario: " + ex.Message);
            }
        }
    }
}



