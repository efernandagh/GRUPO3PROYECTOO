TALLER MECANICO INDUSTRIAL C-MISUR

El sistema informático desarrollado para C-MISUR es una aplicación de gestión administrativa y operativa, creada en Visual Studio, que permite centralizar, organizar y digitalizar los procesos principales del taller mecánico industrial.

## 🧑‍💻 Tecnologías Utilizadas – Proyecto C-MISUR

Este sistema fue desarrollado utilizando las siguientes tecnologías:

###  Lenguaje de Programación
- **C#** – Lenguaje principal del sistema, orientado a objetos y basado en la plataforma .NET.

###  Tipo de Aplicación
- **Windows Forms (.NET)** – Framework utilizado para el desarrollo de la aplicación de escritorio.

###  Base de Datos
- **SQL Server** – Sistema de gestión de base de datos relacional para el almacenamiento de la información.

###  Librerías Utilizadas
- **Microsoft.Data.SqlClient** – Conexión entre la aplicación y la base de datos.
- **ClosedXML** – Exportación de datos a archivos Excel (.xlsx).
- **iTextSharp** – Generación de reportes en formato PDF.

### Entorno de Desarrollo
- **Visual Studio** – IDE utilizado para la programación, depuración y compilación del sistema.

###  Sistema Operativo
- **Windows** – Plataforma donde se ejecuta el sistema.


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


MANUAL TECNICO FACTURACION
FACTURAS:

using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace INICIO
{
    public partial class facturas : Form
    {
        private ConexionBD conexionDB = new ConexionBD();
        private string conexiontionString;

        public facturas()
        {
            InitializeComponent();
        }
        // Carga contratos
        // Carga métodos de pago
        private void facturas_Load(object sender, EventArgs e)
        {
            txtidfactura.Enabled = false;
            GenerarNuevoId();

            
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string query = "SELECT ID_CONTRATO FROM CONTRATOS";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cboidcontrato.Items.Clear();

                    while (reader.Read())
                    {
                        cboidcontrato.Items.Add(reader["ID_CONTRATO"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al cargar contratos: " + ex.Message);
            }

            
            cmbMetodoPago.Items.Clear();
            cmbMetodoPago.Items.Add("Efectivo");
            cmbMetodoPago.Items.Add("Tarjeta");
            cmbMetodoPago.Items.Add("Transferencia");
            cmbMetodoPago.Items.Add("Depósito");

            dtpFecha.Format = DateTimePickerFormat.Custom;
        }
        //limpia los campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtidfactura.Clear();
            cboidcontrato.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            txtMontoTotal.Clear();
            cmbMetodoPago.SelectedIndex = -1;

            MessageBox.Show("Todos los campos han sido limpiados", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //boton para salir de sistema de facturacion
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir del sistema de facturas?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // Validaciones
        // Generar el nuevo ID manualmente
        // Insertar nueva factura
        // Mostrar mensaje de éxito
        // Preguntar si desea registrar pago
        // Aquí podrías abrir el formulario de pagos
        // new pagos(idGenerado).ShowDialog();
        // Actualizar el campo ID en pantalla
        // Actualizar el campo ID en pantalla
        // Mostrar resumen amigable
        // Preguntar si desea crear otra factura
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            
            if (cboidcontrato.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtMontoTotal.Text) ||
                cmbMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("⚠️ Por favor, completa todos los campos.", "Advertencia");
                return;
            }

            if (!decimal.TryParse(txtMontoTotal.Text, out decimal montoDecimal))
            {
                MessageBox.Show("⚠️ El monto debe ser un número válido.", "Advertencia");
                return;
            }

            int idGenerado = 0;

            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                try
                {
                    
                    string getNextIdQuery = "SELECT ISNULL(MAX(ID_FACTURA), 0) + 1 FROM FACTURAS";
                    SqlCommand getIdCmd = new SqlCommand(getNextIdQuery, conn);
                    idGenerado = Convert.ToInt32(getIdCmd.ExecuteScalar());

                    
                    string query = @"INSERT INTO FACTURAS (ID_FACTURA, ID_CONTRATO, FECHA_FACTURA, MONTO_TOTAL, METODO_PAGO)
                                     VALUES (@idfactura, @idcontrato, @fecha, @monto, @metodo)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idfactura", idGenerado);
                    cmd.Parameters.AddWithValue("@idcontrato", Convert.ToInt32(cboidcontrato.SelectedItem));
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value);
                    cmd.Parameters.AddWithValue("@monto", montoDecimal);
                    cmd.Parameters.AddWithValue("@metodo", cmbMetodoPago.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();

                    
                    MessageBox.Show($"✅ Factura guardada correctamente.\n🧾 ID generado: {idGenerado}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    DialogResult result = MessageBox.Show(
                        "¿Desea registrar un pago para esta factura?",
                        "Factura Guardada",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        
                    }

                    
                    txtidfactura.Text = idGenerado.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al guardar: " + ex.Message);
                }
            }

            
            string mensaje = "═══════════════════════════════\n";
            mensaje += "   FACTURA GUARDADA EXITOSAMENTE\n";
            mensaje += "═══════════════════════════════\n\n";
            mensaje += "📋 Contrato: " + cboidcontrato.SelectedItem.ToString() + "\n\n";
            mensaje += "📅 Fecha: " + dtpFecha.Value.ToString("dddd, dd 'de' MMMM 'de' yyyy") + "\n\n";
            mensaje += "💰 Monto Total: L. " + montoDecimal.ToString("N2") + "\n\n";
            mensaje += "💳 Método de Pago: " + cmbMetodoPago.SelectedItem.ToString() + "\n";
            mensaje += "═══════════════════════════════";

            MessageBox.Show(mensaje, "✓ Factura Registrada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            DialogResult respuesta = MessageBox.Show(
                "¿Desea crear otra factura?",
                "Nueva Factura",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                btnLimpiar_Click(sender, e);
                GenerarNuevoId();
            }
            else
            {
                this.Close();
            }
        }

        // Función para generar el siguiente ID automáticamente
        private void GenerarNuevoId()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string consulta = "SELECT ISNULL(MAX(ID_FACTURA), 0) + 1 FROM FACTURAS";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    object resultado = cmd.ExecuteScalar();
                    txtidfactura.Text = resultado?.ToString() ?? "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar ID: " + ex.Message);
                txtidfactura.Text = "1";
            }
        }
        // esto indica que abra con la app predeterminada
        private void btnAyuda_Click(object sender, EventArgs e)
        {

            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = @"C:\Users\Belen\Downloads\MANUAL FACTURACION.pdf",
                UseShellExecute = true 
            };
            System.Diagnostics.Process.Start(psi);
        }
        // Ruta del PDF en la carpeta del ejecutable
        private void btnayuda_Click_1(object sender, EventArgs e)
        {
            
            string rutaPdf = Path.Combine(Application.StartupPath, "MANUAL FACTURACION.pdf");

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

PAGOS:

using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace INICIO
{
    public partial class frmPagos : Form
    {
        //conexion a la base de datos
        private ConexionBD conexionDB = new ConexionBD();
        private string conexiontionString;
        public frmPagos()
        {
            InitializeComponent();
            CargarFacturas();

            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    MessageBox.Show("✅ Conexión exitosa a la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error de conexión: " + ex.Message);
            }
        }


        //  Cargar al iniciar el formulario
        // Cargar estados de pago
        // Cargar facturas desde la base de datos

        private void frmPagos_Load(object sender, EventArgs e)
        {
            txtPago.Enabled = false;
            GenerarNuevoId();
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dd/MM/yyyy";

            
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Pendiente");
            cboEstado.Items.Add("Pagado");
            cboEstado.Items.Add("Cancelado");
            cboEstado.SelectedIndex = 0;

            
            CargarFacturas();
        }

        // Cargar los ID_FACTURA en el ComboBox
        private void CargarFacturas()
        {
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string query = "SELECT ID_FACTURA FROM FACTURAS";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbidfaactura.Items.Clear();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("⚠️ No hay facturas registradas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    while (reader.Read())
                    {
                        cmbidfaactura.Items.Add(reader["ID_FACTURA"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al cargar facturas: " + ex.Message, "Error");
            }
        }



        //  Botón Limpiar
        // Método para limpiar todos los campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MessageBox.Show("Formulario limpiado correctamente.", "Limpieza", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void LimpiarCampos()
        {
            txtPago.Clear();
            txtMonto.Clear();
            dtpFecha.Value = DateTime.Now;
            cboEstado.SelectedIndex = 0;
            cmbidfaactura.SelectedIndex = -1;
            txtPago.Focus();
        }

        // Botón Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?",
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
                this.Close();
        }

        // Validar entrada numérica en txtMonto
        // Permitir solo números, punto decimal y teclas de control
        // Permitir solo un punto decimal
        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            
            if (e.KeyChar == '.' && txtMonto.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        //validaciones
        //Generar nuevo ID_PAGO manualmente
        //inserta el nuevo pago
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                /
                if (cmbidfaactura.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una factura.", "Advertencia");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMonto.Text))
                {
                    MessageBox.Show("Ingrese un monto válido.", "Advertencia");
                    return;
                }

                if (!decimal.TryParse(txtMonto.Text, out decimal monto))
                {
                    MessageBox.Show("El monto debe ser numérico.", "Error");
                    return;
                }

                if (cboEstado.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un estado.", "Advertencia");
                    return;
                }

                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    
                    long nuevoId = 0;
                    using (SqlCommand cmdId = new SqlCommand("SELECT ISNULL(MAX(ID_PAGO), 0) + 1 FROM PAGOS", conn))
                    {
                        nuevoId = Convert.ToInt64(cmdId.ExecuteScalar());
                    }

                    
                    string query = @"INSERT INTO PAGOS (ID_PAGO, ID_FACTURA, FECHA_PAGO, MONTO_PAGO, ESTADO_PAGO)
                             VALUES (@idpago, @idfactura, @fecha, @monto, @estado)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idpago", nuevoId);
                    cmd.Parameters.AddWithValue("@idfactura", Convert.ToInt64(cmbidfaactura.SelectedItem));
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value);
                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.Parameters.AddWithValue("@estado", cboEstado.SelectedItem.ToString());

                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("✅ Pago guardado correctamente.", "Éxito");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("⚠️ No se insertó ningún registro.", "Aviso");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"❌ Error SQL: {ex.Message}", "Error SQL");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error general: {ex.Message}", "Error");
            }
        }
        // Función para generar el siguiente ID automáticamente
        private void frmPagos_Load_1(object sender, EventArgs e)
        {
            txtPago.Enabled = false;
            GenerarNuevoId();
        }

        private int ObtenerSiguienteIdUsuario()
        {
            int siguienteId = 1;

            using (SqlConnection conexion = new SqlConnection(conexiontionString))
            {
                conexion.Open();
                string consulta = "SELECT ISNULL(MAX(ID_PAGO), 0) + 1 FROM PAGOS";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                siguienteId = Convert.ToInt32(comando.ExecuteScalar());
            }

            return siguienteId;
        }
        //genera automaticamente el pago id
        private void GenerarNuevoId()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    
                    string consulta = "SELECT ISNULL(MAX(ID_PAGO), 0) + 1 FROM PAGOS";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    object resultado = cmd.ExecuteScalar();
                    txtPago.Text = (resultado != null) ? resultado.ToString() : "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar ID: " + ex.Message);
                txtPago.Text = "1";
            }
        }
        // abre con la aplicación predeterminada
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = @"C:\Users\Belen\Downloads\MANUAL PAGOS.pdf",
                UseShellExecute = true 
            };
            System.Diagnostics.Process.Start(psi);
        }
        // Ruta del PDF en la carpeta del ejecutable
        private void btnayuda_Click_1(object sender, EventArgs e)
        {
            
            string rutaPdf = Path.Combine(Application.StartupPath, "MANUAL PAGOS.pdf");

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
