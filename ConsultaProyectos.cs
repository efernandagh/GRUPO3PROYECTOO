using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using Microsoft.Data.SqlClient;

namespace INICIO
{
    public partial class ConsultaProyectos : Form
    {
        public ConsultaProyectos()
        {
            InitializeComponent();
        }

        private void ConsultaProyectos_Load(object sender, EventArgs e)
        {
            // 🔹 Llenar ComboBox de tablas
            cbotabla.Items.Add("PROYECTOS");
            cbotabla.Items.Add("SEGUIMIENTO");
            cbotabla.Items.Add("CONTRATOS");
            cbotabla.Items.Add("PROCESOS");
            cbotabla.SelectedIndex = 0;

            // 🔹 Cargar columnas iniciales
            CargarColumnas("PROYECTOS");
        }

        // 🔹 Cuando cambia la tabla
        private void cbotabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tablaSeleccionada = cbotabla.Text;
            CargarColumnas(tablaSeleccionada);

            // Limpiar combos dependientes
            cbDescripcion.Items.Clear();
            cbDescripcion.Text = "";
        }

        // 🔹 Cargar columnas según tabla seleccionada
        private void CargarColumnas(string tabla)
        {
            cbobuscar.Items.Clear();

            switch (tabla)
            {
                case "PROYECTOS":
                    cbobuscar.Items.AddRange(new string[] {
                        "ID_PROYECTO", "NOMBRE_PROYECTO", "DESCRIPCION",
                        "FECHA_INICIO", "FECHA_FIN", "ESTADO", "ID_USUARIO"
                    });
                    break;

                case "SEGUIMIENTO":
                    cbobuscar.Items.AddRange(new string[] {
                        "ID_SEGUIMIENTO", "ID_CONTRATO", "FECHA_SEGUIMIENTO",
                        "DESCRIPCION", "NIVEL_SATISFACTORIO"
                    });
                    break;

                case "CONTRATOS":
                    cbobuscar.Items.AddRange(new string[] {
                        "ID_CONTRATO", "ID_CLIENTE", "ID_SERVICIO",
                        "FECHA_INICIO", "FECHA_FIN", "ESTADO"
                    });
                    break;

                case "PROCESOS":
                    cbobuscar.Items.AddRange(new string[] {
                        "ID_PROCESOS", "NOMBRE_PROCESO", "DESCRIPCION", "ID_USUARIO"
                    });
                    break;
            }

            if (cbobuscar.Items.Count > 0)
                cbobuscar.SelectedIndex = 0;
        }

        // 🔹 Cuando cambia el campo "Buscar"
        private void cbobuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tabla = cbotabla.Text;
            string columna = cbobuscar.Text;

            if (!string.IsNullOrEmpty(tabla) && !string.IsNullOrEmpty(columna))
            {
                CargarDescripcion(tabla, columna);
            }
        }

        // 🔹 Cargar los valores distintos del campo seleccionado
        private void CargarDescripcion(string tabla, string columna)
        {
            cbDescripcion.Items.Clear();

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = $"SELECT DISTINCT {columna} FROM {tabla}";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        cbDescripcion.Items.Add(dr[columna].ToString());
                    }

                    dr.Close();

                    if (cbDescripcion.Items.Count > 0)
                        cbDescripcion.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar descripciones: " + ex.Message);
            }
        }

        // 🔹 Buscar registros al seleccionar una descripción
        private void cbDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tabla = cbotabla.Text;
            string columna = cbobuscar.Text;
            string valor = cbDescripcion.Text;

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
                    dtvproyectos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar registros: " + ex.Message);
            }
        }

        // 🔹 Botón BUSCAR (por si deseas buscar manualmente con texto)
        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            string tabla = cbotabla.Text;
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
                    string query = $"SELECT * FROM {tabla} WHERE {columna} LIKE '%' + @valor + '%'";
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
            cbDescripcion.Items.Clear();
            dtvproyectos.DataSource = null;
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir del sistema?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
                this.Close();
        }

        private void dtvproyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dtvproyectos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear un DataTable desde el DataGridView
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn col in dtvproyectos.Columns)
                {
                    dt.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dtvproyectos.Rows)
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