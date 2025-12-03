TALLER MECANICO INDUSTRIAL C-MISUR

El sistema informático desarrollado para C-MISUR es una aplicación de gestión administrativa y operativa, creada en Visual Studio, que permite centralizar, organizar y digitalizar los procesos principales del taller mecánico industrial.

MANUAL TECNICO LOGIN

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace INICIO
{
    public partial class ConsultaServicio : Form
    {
        //Inicializa todos los componentes gráficos del formulario.
        public ConsultaServicio()
        {
            InitializeComponent();
        }
        //Carga las tablas disponibles para consulta y prepara los combos.

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
                    CargarDescripcion(cmbtabla.Text, cbmbuscar.Text);
                    CargarDatos(cmbtabla.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar combos: " + ex.Message);
            }
        }

        //Pregunta al usuario si desea cerrar el formulario.


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

        //Restablece los combos, limpia el datagridview, elimina cualquier filtro aplicado
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            cmbdescripcion.SelectedIndex = 0;
            cbmbuscar.SelectedIndex = 0;
            dgvservicio.DataSource = null;
        }

        //Permite la búsqueda manual por filtro.
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string tabla = cmbtabla.Text;
            string columna = cbmbuscar.Text;
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
                    dgvservicio.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }

        }

        //Permite la búsqueda manual por filtro.
        private void cbmbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tabla = cmbtabla.Text;
            string columna = cbmbuscar.Text;

            if (!string.IsNullOrEmpty(tabla) && !string.IsNullOrEmpty(columna))
            {
                CargarDescripcion(tabla, columna);
            }
        }

        // 🔹 Cargar los valores distintos del campo seleccionado
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
                        cmbdescripcion.Items.Add(dr[columna].ToString());

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

        //Se ejecuta al cargar el formulario e inicializa todos los combos llamando a: InicializarCombos();
        private void ConsultaServicio_Load(object sender, EventArgs e)
        {

            InicializarCombos();
        }

        //Cada vez que cambia la columna:
       // Se recargan los valores disponibles con CargarDescripcion().
        private void cmbbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tablaSeleccionada = cmbtabla.Text;
            CargarColumnas(tablaSeleccionada);

            // Limpiar combos dependientes
            cmbdescripcion.Items.Clear();
            cmbdescripcion.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Este evento se ejecuta automáticamente cuando el usuario selecciona un valor en el ComboBox cmbdescripcion.
       // Su objetivo es realizar una búsqueda inmediata en la base de datos según el valor seleccionado y mostrar los resultados en el DataGridView dgvservicio.
        private void cmbdescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tabla = cmbtabla.Text;
            string columna = cbmbuscar.Text;
            string valor = cmbdescripcion.Text.Trim();

            if (string.IsNullOrEmpty(valor))
            {
                MessageBox.Show("Seleccione un valor para buscar.", "Atención");
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

        //Generación de reportes en formato Excel para control administrativo.
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvservicio.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear un DataTable desde el DataGridView
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn col in dgvservicio.Columns)
                {
                    dt.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvservicio.Rows)
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
                sfd.FileName = "ServiciosExportados.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        // Crear hoja y agregar datos
                        var ws = wb.Worksheets.Add(dt, "Resultados");

                        // Insertar filas para encabezado
                        ws.Row(1).InsertRowsAbove(2);

                        // Encabezado principal con el nombre de la empresa
                        ws.Cell("A1").Value = "C-MISUR - Control Mecánico Industrial de Servicios y Reparaciones";
                        ws.Cell("A1").Style.Font.Bold = true;
                        ws.Cell("A1").Style.Font.FontSize = 16;
                        ws.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        // Combinar celdas del encabezado (depende del número de columnas)
                        int totalColumnas = dt.Columns.Count;
                        ws.Range(1, 1, 1, totalColumnas).Merge();

                        // Color de fondo del encabezado
                        ws.Range(1, 1, 1, totalColumnas).Style.Fill.BackgroundColor = XLColor.FromHtml("#D9E1F2");

                        // (Opcional) Fecha y hora de exportación debajo del título
                        ws.Cell("A2").Value = "Exportado el " + DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                        ws.Cell("A2").Style.Font.Italic = true;
                        ws.Range(2, 1, 2, totalColumnas).Merge();
                        ws.Cell("A2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        // Ajustar ancho de columnas automáticamente
                        ws.Columns().AdjustToContents();

                        wb.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("Datos exportados correctamente C-MISUR.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Generación de reportes en formato Excel para control administrativo.
        private void btnExportarPDF_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    if (dgvservicio.Rows.Count == 0)
                    {
                        MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (dgvservicio.Columns.Count == 0)
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
                        int columnas = dgvservicio.Columns.Count;
                        PdfPTable tabla = new PdfPTable(columnas);
                        tabla.WidthPercentage = 100;

                        // Encabezados de columnas
                        var headerFont = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD);
                        foreach (DataGridViewColumn col in dgvservicio.Columns)
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
                        foreach (DataGridViewRow fila in dgvservicio.Rows)
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
        }
        //Este evento se ejecuta cuando el usuario presiona el botón “Ayuda”.
       // Su función es abrir el Manual de Usuario en formato PDF correspondiente al módulo de Consulta de Servicios, directamente desde la carpeta donde se encuentra el ejecutable del sistema.
        private void btnayuda_Click(object sender, EventArgs e)
        {// Ruta del PDF en la carpeta del ejecutable
            string rutaPdf = Path.Combine(Application.StartupPath, "MANUAL DE USUARIO CONSULTA SERVICIOS.pdf");

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


