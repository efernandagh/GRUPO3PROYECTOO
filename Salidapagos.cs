using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            cmbtabla.SelectedIndex = 0;
            cmbdescrip.SelectedIndex = 0;
            dtvpagos.DataSource = null; ;
        }

        private void Salidapagos_Load(object sender, EventArgs e)
        {
            cmbtabla.Items.AddRange(new string[] { "FACTURAS", "PAGOS" });
            cmbtabla.SelectedIndex = 0;
            CargarColumnas("FACTURAS");
            CargarValoresDescripcion("FACTURAS", cbobuscar.SelectedItem.ToString());
            CargarDatos();
        }
        private void CargarDescripcion()
        {
            cmbdescrip.Items.Clear();

            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string campo = cbobuscar.SelectedItem.ToString();
                string query = $"SELECT DISTINCT {campo} FROM PAGOS";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cmbdescrip.Items.Add(dr[0].ToString());
                }
            }

            if (cmbdescrip.Items.Count > 0)
                cmbdescrip.SelectedIndex = 0;
        }
        private void CargarDatos()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string tabla = cmbtabla.Text;
                    string columna = cbobuscar.Text;
                    string valor = cmbdescrip.Text;

                    string query = $"SELECT * FROM {tabla}";

                    if (!string.IsNullOrEmpty(valor))
                    {
                        if (columna.Contains("FECHA"))
                        {
                            query += $" WHERE CONVERT(date, {columna}) = '{valor}'";
                        }
                        else
                        {
                            query += $" WHERE {columna} LIKE '%{valor}%'";
                        }
                    }

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtvpagos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void InicializarCombos()
        {
            try
            {
                cmbtabla.Items.Clear();
                cmbtabla.Items.Add("PAGOS");
                cmbtabla.Items.Add("FACTURAS");

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
        // ✅ Cargar valores únicos de la columna seleccionada en el ComboBox descripción
        private void CargarValoresDescripcion(string tabla, string columna)
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = $"SELECT DISTINCT {columna} FROM {tabla}";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbdescrip.Items.Clear();

                    while (reader.Read())
                    {
                        if (reader[columna] != DBNull.Value)
                        {
                            if (reader[columna] is DateTime dt)
                                cmbdescrip.Items.Add(dt.ToString("yyyy-MM-dd"));
                            else if (reader[columna] is decimal or double or float)
                                cmbdescrip.Items.Add(Convert.ToDecimal(reader[columna]).ToString());
                            else
                                cmbdescrip.Items.Add(reader[columna].ToString());
                        }
                    }

                    if (cmbdescrip.Items.Count > 0) cmbdescrip.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar valores únicos: " + ex.Message);
            }
        }

        private void CargarColumnas(string tabla)
        {
            cbobuscar.Items.Clear();

            switch (tabla)
            {
                case "PAGOS":
                    cbobuscar.Items.AddRange(new string[]
                    {
                "ID_PAGO",
                "ID_FACTURA",
                "FECHA_PAGO",
                "MONTO_PAGO",
                "ESTADO_PAGO"
                    });
                    break;

                case "FACTURAS":
                    cbobuscar.Items.AddRange(new string[]
                    {
                "ID_FACTURA",
                "ID_CONTRATO",
                "FECHA_FACTURA",
                "MONTO_TOTAL",
                "METODO_PAGO"
                    });
                    break;
            }

            if (cbobuscar.Items.Count > 0)
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


        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }



        private void dtvpagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbobuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarValoresDescripcion(cmbtabla.Text, cbobuscar.Text);
        }


        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbtabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarColumnas(cmbtabla.Text);
            CargarValoresDescripcion(cmbtabla.Text, cbobuscar.Text);
            CargarDatos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbdescrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
            if (cmbdescrip.SelectedIndex < 0) return;

            string tabla = cmbtabla.Text;
            string columna = cbobuscar.Text;
            string valor = cmbdescrip.Text;

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    string query = $"SELECT * FROM {tabla} WHERE ";

                    // ✅ Detectar fecha correctamente
                    if (columna.ToUpper().Contains("FECHA"))
                    {
                        query += $"CONVERT(date,{columna}) = @valor";
                        cmd.Parameters.AddWithValue("@valor", DateTime.Parse(valor));
                    }
                    // ✅ Detectar montos decimal
                    else if (columna.ToUpper().Contains("MONTO"))
                    {
                        query += $"{columna} = @valor";
                        cmd.Parameters.AddWithValue("@valor", decimal.Parse(valor));
                    }
                    // ✅ Detectar ID (entero)
                    else if (columna.ToUpper().Contains("ID"))
                    {
                        query += $"{columna} = @valor";
                        cmd.Parameters.AddWithValue("@valor", int.Parse(valor));
                    }
                    // ✅ Texto
                    else
                    {
                        query += $"{columna} LIKE '%' + @valor + '%'";
                        cmd.Parameters.AddWithValue("@valor", valor);
                    }

                    cmd.CommandText = query;

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

        private void btnexcel_Click(object sender, EventArgs e)
        {
            if (dtvpagos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear un DataTable desde el DataGridView
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn col in dtvpagos.Columns)
                {
                    dt.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dtvpagos.Rows)
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

        private void btnpdf_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtvpagos.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtvpagos.Columns.Count == 0)
                {
                    MessageBox.Show("No hay columnas para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Archivo PDF|*.pdf";
                sfd.FileName = "ServiciosExportados.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    // Encabezado
                    var tituloFont = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD);
                    Paragraph encabezado = new Paragraph("C-MISUR\nControl Mecánico Industrial de Servicios y Reparaciones", tituloFont);
                    encabezado.Alignment = Element.ALIGN_CENTER;
                    encabezado.SpacingAfter = 12f;
                    doc.Add(encabezado);

                    // Crear tabla
                    int columnas = dtvpagos.Columns.Count;
                    PdfPTable tabla = new PdfPTable(columnas);
                    tabla.WidthPercentage = 100;

                    // Encabezados de columnas
                    var headerFont = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD);
                    foreach (DataGridViewColumn col in dtvpagos.Columns)
                    {
                        string headerText = col.HeaderText ?? "";
                        PdfPCell celdaHeader = new PdfPCell(new Phrase(headerText, headerFont));
                        celdaHeader.HorizontalAlignment = Element.ALIGN_CENTER;
                        celdaHeader.VerticalAlignment = Element.ALIGN_MIDDLE;
                        celdaHeader.BackgroundColor = new BaseColor(217, 225, 242); // azul claro
                        tabla.AddCell(celdaHeader);
                    }

                    // Filas de datos
                    var cellFont = FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL);
                    foreach (DataGridViewRow fila in dtvpagos.Rows)
                    {
                        if (!fila.IsNewRow)
                        {
                            foreach (DataGridViewCell celda in fila.Cells)
                            {
                                string texto = celda?.Value?.ToString() ?? "";
                                PdfPCell pcell = new PdfPCell(new Phrase(texto, cellFont));
                                pcell.HorizontalAlignment = Element.ALIGN_LEFT;
                                tabla.AddCell(pcell);
                            }
                        }
                    }

                    doc.Add(tabla);
                    doc.Close();

                    MessageBox.Show("PDF exportado correctamente C-MISUR.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
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

        private void btnayuda_Click(object sender, EventArgs e)
        {
            // Ruta del PDF en la carpeta del ejecutable
            string rutaPdf = Path.Combine(Application.StartupPath, "Manual de usuario consulta Facturación.pdf");

            if (File.Exists(rutaPdf))
            {
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = rutaPdf,
                        UseShellExecute = true
                    };
                    Process.Start(psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo abrir el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
