using ClosedXML.Excel;
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
                    CargarDatos(cmbtabla.SelectedItem.ToString());
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

            // limpiar y recargar descripciones y datos
            cmbdescripcion.Items.Clear();
            cmbdescripcion.Text = "";
            CargarDescripcion(tablaSeleccionada, cmbbuscar.Text);
            CargarDatos(tablaSeleccionada);
        }

        private void cmbbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cuando cambia la columna, recargar posibles descripciones
            CargarDescripcion(cmbtabla.Text, cmbbuscar.Text);
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
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;

                    // Si columna es fecha, convertir y comparar por fecha (sin hora)
                    if (columna.ToUpper().Contains("FECHA"))
                    {
                        if (!DateTime.TryParse(valor, out DateTime fecha))
                        {
                            MessageBox.Show("Formato de fecha inválido en la descripción.");
                            return;
                        }

                        cmd.CommandText = $"SELECT * FROM {tabla} WHERE CONVERT(date, {columna}) = @valor";
                        cmd.Parameters.AddWithValue("@valor", fecha.Date);
                    }
                    else if (columna.ToUpper().Contains("CANTIDAD") ||
                             columna.ToUpper().Contains("ID") && int.TryParse(valor, out _))
                    {
                        // buscar por valor numérico entero si aplica
                        if (int.TryParse(valor, out int intVal))
                        {
                            cmd.CommandText = $"SELECT * FROM {tabla} WHERE {columna} = @valor";
                            cmd.Parameters.AddWithValue("@valor", intVal);
                        }
                        else
                        {
                            // si no es entero, usar LIKE (texto)
                            cmd.CommandText = $"SELECT * FROM {tabla} WHERE {columna} LIKE '%' + @valor + '%'";
                            cmd.Parameters.AddWithValue("@valor", valor);
                        }
                    }
                    else if (columna.ToUpper().Contains("MONTO") || columna.ToUpper().Contains("PRECIO"))
                    {
                        // intentar decimal
                        if (decimal.TryParse(valor, out decimal decVal))
                        {
                            cmd.CommandText = $"SELECT * FROM {tabla} WHERE {columna} = @valor";
                            cmd.Parameters.AddWithValue("@valor", decVal);
                        }
                        else
                        {
                            cmd.CommandText = $"SELECT * FROM {tabla} WHERE {columna} LIKE '%' + @valor + '%'";
                            cmd.Parameters.AddWithValue("@valor", valor);
                        }
                    }
                    else
                    {
                        // búsqueda de texto por defecto
                        cmd.CommandText = $"SELECT * FROM {tabla} WHERE {columna} LIKE '%' + @valor + '%'";
                        cmd.Parameters.AddWithValue("@valor", valor);
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvinventario.DataSource = dt;

                        if (dt.Rows.Count == 0)
                            MessageBox.Show("No se encontraron registros para la selección.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void ConsultaInventario_Load(object sender, EventArgs e)
        {
            InicializarCombos();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvinventario.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear un DataTable desde el DataGridView
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn col in dgvinventario.Columns)
                {
                    dt.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvinventario.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        dt.Rows.Add(row.Cells.Cast<DataGridViewCell>()
                            .Select(c => c.Value?.ToString()).ToArray());
                    }
                }

                // Guardar archivo
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Workbook|*.xlsx";
                sfd.FileName = "ConsultaExportada.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        wb.Worksheets.Add(dt, "Resultados");
                        wb.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("Datos exportados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}



