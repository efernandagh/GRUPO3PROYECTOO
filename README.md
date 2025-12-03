# TALLER MECÁNICO INDUSTRIAL C-MISUR

El sistema informático desarrollado para **C-MISUR** es una **aplicación de gestión administrativa y operativa**, construida en **Visual Studio con lenguaje C# (Windows Forms)**. Su objetivo principal es **centralizar, organizar y digitalizar los procesos clave del taller mecánico industrial**, permitiendo una administración eficiente, segura y confiable de la información.

Este sistema facilita el control de:
- Clientes  
- Servicios  
- Inventarios  
- Reportes administrativos  
- Exportación de información a Excel y PDF  

Además, incorpora mecanismos de búsqueda, filtrado de datos y generación de reportes, optimizando los tiempos de trabajo y la toma de decisiones dentro del taller.

El proyecto está orientado a mejorar la calidad del servicio, reducir errores manuales y fortalecer la gestión interna del Taller Mecánico Industrial C-MISUR.


## Tecnologías Utilizadas – Proyecto C-MISUR

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

  ## Pruebas del Sistema

### 1. Cómo probar la aplicación

Para realizar pruebas funcionales del sistema C-MISUR se recomienda seguir los siguientes pasos:

1. Ejecutar la aplicación desde Visual Studio.
2. Verificar que la conexión a la base de datos esté correctamente configurada.
3. Utilizar usuarios de prueba previamente registrados en el sistema.
4. Insertar datos de ejemplo en las tablas principales:
   - CLIENTES
   - SERVICIOS
   - INVENTARIO
5. Probar los módulos principales:
   - Registro de clientes
   - Consulta de servicios
   - Generación de reportes
   - Exportación a Excel y PDF

#### Usuarios de prueba (ejemplo)
- **Usuario:** admin  
  **Contraseña:** admin123  
  **Rol:** Administrador  

- **Usuario:** usuario1  
  **Contraseña:** user123  
  **Rol:** Usuario estándar  

#### Datos de ejemplo
- Clientes de prueba con nombre, correo, teléfono y dirección.
- Servicios de prueba con nombre y descripción.
- Registros simulados de inventario y órdenes de trabajo.

---

### 2. Casos de Uso Críticos a Validar

Los siguientes casos de uso son considerados críticos y deben ser validados en cada prueba del sistema:

1. **Inicio de sesión del usuario**
   - Verificar acceso correcto con credenciales válidas.
   - Validar bloqueo de acceso con credenciales incorrectas.

2. **Registro de clientes**
   - Agregar nuevos clientes.
   - Validar campos obligatorios.
   - Evitar registros duplicados.

3. **Consulta de servicios**
   - Búsqueda por nombre, ID o descripción.
   - Visualización correcta en el DataGridView.
   - Filtros dinámicos por campo.

4. **Exportación de reportes**
   - Exportar datos a Excel.
   - Exportar datos a PDF.
   - Verificar integridad de los datos exportados.

5. **Gestión de inventario**
   - Ingreso de nuevos productos.
   - Actualización de existencias.
   - Validación de stock mínimo.

6. **Salida segura del sistema**
   - Confirmación al cerrar sesión.
   - Protección contra cierre accidental del programa.

---

### 3. Resultados Esperados de las Pruebas

- El sistema debe responder sin errores durante las operaciones.
- Los datos deben almacenarse correctamente en la base de datos.
- Los reportes deben generarse sin pérdida de información.
- La interfaz debe responder de forma rápida y estable.

## Base de Datos

### Motor Soportado
El sistema C-MISUR utiliza exclusivamente el siguiente motor de base de datos:

- **SQL Server**

### Tablas Principales
Las principales tablas utilizadas en el sistema son:

- **Clientes**: Almacena la información de los clientes del taller.
- **Facturas**: Registra las facturas generadas por los servicios prestados.
- **Usuarios**: Controla el acceso al sistema mediante credenciales y roles.
- **Servicios**: Contiene el catálogo de servicios ofrecidos.
- **Inventario**: Administra los productos, repuestos y herramientas.
- **Órdenes de Trabajo**: Registra los trabajos realizados en el taller.
- **Pagos**: Almacena los registros de pagos efectuados por los clientes.

Estas tablas permiten la correcta integración entre los módulos administrativos y operativos del sistema.

## Equipo de Desarrollo

- **Enia Gomez** – 
- **Helen Sanchez** – 
- **Alejandro Callison** –
- - **Aron**

## Entorno de Desarrollo

- **IDE:** Visual Studio 2022 (v17.x)
- **Lenguaje:** C#
- **Framework:** .NET Framework 4.7 o superior

## MANUAL TECNICO LOGIN

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

## MANUAL TECNICO MENU
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INICIO
{
    
    //Esta clase representa el menu principal del sistema, donde se accede a todos
    //los modulos funcionales
    public partial class Menu : Form
    
    {
        
        //Inicializa todos los controles gráficos definidos en el diseñador de Windows Forms.
        
        public Menu()
        {
            
            InitializeComponent();
        }
        
        //Finaliza completamente la ejecución del sistema.
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //Muestra el submenú de proyectos.
        private void btnproyectos_Click(object sender, EventArgs e)
        {
            Submenuproyectos.Visible = true;
        }
        //Este boton ocultan el submenú
        private void btnproyectoinventario_Click(object sender, EventArgs e)
        {
            Submenuproyectos.Visible = false;
        }
        //Este boton ocultan el submenú
        private void btnseguimiento_Click(object sender, EventArgs e)
        {
            Submenuproyectos.Visible = false;
        }
        //Este boton ocultan el submenú
        private void btncontratos_Click(object sender, EventArgs e)
        {
            Submenuproyectos.Visible = false;
        }
        //Este botonocultan el submenú
        private void btnprocesos_Click(object sender, EventArgs e)
        {
            Submenuproyectos.Visible = false;
        }
        //Muestra el submenú de servicios.
        private void btnservicios_Click(object sender, EventArgs e)
        {
            Submenuservicios.Visible = true;
        }
        // //Este botonocultan el submenú
        private void btnservicios2_Click(object sender, EventArgs e)
        {
            Submenuservicios.Visible = false;
        }
        // //Este botonocultan el submenú
        private void btnclientes_Click(object sender, EventArgs e)
        {
            Submenuservicios.Visible = false;
        }
        //Muestra el submenú de inventaeios
        private void btninventario_Click(object sender, EventArgs e)
        {
            submenuinvenatario.Visible = true;
        }
        // //Este botonocultan el submenú
        private void btninventario2_Click(object sender, EventArgs e)
        {
            submenuinvenatario.Visible = false;
        }
        // //Este botonocultan el submenú
        private void btnproveedores_Click(object sender, EventArgs e)
        {
            submenuinvenatario.Visible = false;
        }
        //Muestra el submenú de facturacion
        private void btnfacturacion_Click(object sender, EventArgs e)
        {
            submenufacturacion.Visible = true;
        }

        
        private void btnfacturas_Click(object sender, EventArgs e)
        {
            submenufacturacion.Visible = false;
            //Apertura de Facturas:
            AbrirFormulario(new facturas());
        }

        private void btnpagos_Click(object sender, EventArgs e)
        {
            submenufacturacion.Visible = false;
            //Apertura de Pagos:
            AbrirFormulario(new frmPagos());
        }
        //Accesos administrativos:
        private void btnadmin_Click(object sender, EventArgs e)
        {
            ssubmenuadmin.Visible = true;
        }
        //Cada botón invoca un formulario independiente mediante el panel contenedor.
        private void btnroles_Click(object sender, EventArgs e)
        {
            ssubmenuadmin.Visible = false;
            AbrirFormulario(new roles());
        }
        //Cada botón invoca un formulario independiente mediante el panel contenedor.
        private void btnusuarios_Click(object sender, EventArgs e)
        {
            ssubmenuadmin.Visible = false;
            AbrirFormulario(new usuarios());
        }
        //Despliega el menú general de módulos
        //Cada uno abre su formulario correspondiente
        private void button11_Click(object sender, EventArgs e)
        {
            menupa.Visible = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnproy3_Click(object sender, EventArgs e)
        {
            menupa.Visible = false;
            AbrirFormulario(new proyecto());
        }

        private void btnsegui_Click(object sender, EventArgs e)
        {
            menupa.Visible = false;
            AbrirFormulario(new seguimiento());

        }

        private void btncontr_Click(object sender, EventArgs e)
        {
            menupa.Visible = false;
            AbrirFormulario(new contratos());
        }

        private void btnproc_Click(object sender, EventArgs e)
        {
            menupa.Visible = false;
            AbrirFormulario(new Procesos());
        }

        private void btnservi_Click(object sender, EventArgs e)
        {
            menuservi.Visible = true;
        }

        private void btnservi2_Click(object sender, EventArgs e)
        {
            menuservi.Visible = false;
            AbrirFormulario(new servicios());
        }

        private void btnclien_Click(object sender, EventArgs e)
        {
            menuservi.Visible = false;
            AbrirFormulario(new clientes());
        }

        private void btninvent_Click(object sender, EventArgs e)
        {
            menuinvent.Visible = true;
        }

        private void btninvent2_Click(object sender, EventArgs e)
        {
            menuinvent.Visible = false;
            AbrirFormulario(new inventario());
        }

        private void btnprovee_Click(object sender, EventArgs e)
        {

            menuinvent.Visible = false;
            AbrirFormulario(new proveedores());
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormulario(Form formularioHijo)
        {
            // Limpia el panel antes de abrir otro formulario
            Panelcontenedor.Controls.Clear();

            // Configuración del formulario hijo
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            // Agregar al panel
            Panelcontenedor.Controls.Add(formularioHijo);
            Panelcontenedor.Tag = formularioHijo;
            formularioHijo.Show();

        }


        private void Panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        //Cierra completamente la aplicación.
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Maximiza la ventana y oculta el botón
        private void btnmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmax.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            button2.Visible = true;
        }
        //Minimiza la ventana.
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Este evento se ejecuta cuando el usuario hace clic en el botón “Respaldo” dentro del submenú de administración.
       // Su propósito es ocultar el submenú administrativo y abrir el módulo de respaldo y restauración de la base de datos.
        private void btnrespaldo_Click(object sender, EventArgs e)
        {
            ssubmenuadmin.Visible = false;
            AbrirFormulario(new RespaldoYrestaurar());

            RespaldoYrestaurar ventanaBackup = new RespaldoYrestaurar();
            ventanaBackup.ShowDialog(); // Abre la ve

        }

        private void btnsalidapagos_Click(object sender, EventArgs e)
        {
            ssubmenuadmin.Visible = false;
            AbrirFormulario(new Salidapagos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que quieres abrir
            Menuconsultas frmConsultas = new Menuconsultas();

            // Mostrarlo en pantalla completa
            frmConsultas.WindowState = FormWindowState.Maximized;

            // Mostrar el formulario
            frmConsultas.Show();

            // Ocultar el formulario actual (el menú)
            this.Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ssubmenuadmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndash_Click(object sender, EventArgs e)
        {
            ssubmenuadmin.Visible = false;
            AbrirFormulario(new Dashboard());
        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            // Ruta del PDF en la carpeta del ejecutable
            string rutaPdf = Path.Combine(Application.StartupPath, "Manual de usuario menu principal.pdf");

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


## MANUAL TECNICO FACTURACION
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

PARTE ADMINISTRATIVA
ROLES:


namespace INICIO
{// Instancia de la clase de conexión
    public partial class roles : Form
    {
        private string conexiontionString;
        private ConexionBD conexionDB = new ConexionBD(); 




        public roles()
        {
            InitializeComponent();
        }

        private void roles_Load(object sender, EventArgs e)
        {
            CargarRoles();


        }




        // Método que carga los roles disponibles desde la base de datos y los muestra en un ComboBox
        // Establece una conexión con la base de datos usando el patrón 'using' para garantizar su cierre automático
        // Define la consulta SQL para obtener el ID y nombre de todos los roles
        // Crea el comando SQL con la consulta y la conexión
        // Ejecuta la consulta y obtiene un lector de datos
        public void CargarRoles()
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {

                    string query = "SELECT ID_ROL, NOMBRE_ROL FROM ROL";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    cmbnombrerol.DataSource = dt;
                    cmbnombrerol.DisplayMember = "NOMBRE_ROL";
                    cmbnombrerol.ValueMember = "ID_ROL";
                    cmbnombrerol.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al cargar roles: " + ex.Message);
                }
            }
        }
        // Evento del botón guardar que inserta un nuevo rol en la base de datos
        // Obtiene y valida los datos ingresados en los campos del formulario
        // Valida que los campos obligatorios no estén vacíos
        // Refrescar roles en el formulario de usuarios
        private void btnguardar_Click(object sender, EventArgs e)
        {
            string id = txtidrol.Text.Trim();
            string nombre = cmbnombrerol.Text.Trim();
            string descripcion = txtdescrip.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {

                    string query = "INSERT INTO ROL (ID_ROL ,NOMBRE_ROL, DESCRIPCION) VALUES (@idrol, @Nombre, @Descripcion)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@idrol", id);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Rol guardado correctamente en SQL.");

                    
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f is usuarios)
                        {
                            ((usuarios)f).CargarRoles();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al guardar: " + ex.Message);
            }

            cmbnombrerol.Text = "";
            txtdescrip.Clear();
            txtdescrip.Focus();
        }



        // Evento del botón eliminar que borra un rol de la base de datos por su ID
        // Valida que se haya ingresado un ID de rol
        // Ejecuta la eliminación del rol en la tabla ROL
        // Verifica si se eliminó algún registro y muestra el resultado
        // Limpia todos los campos después de la operación
        private void btneliminar_Click(object sender, EventArgs e)
        {
            string id = txtidrol.Text;

            if (id == "")
            {
                MessageBox.Show("Ingresa el Id del rol a eliminar.");
                return;
            }

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {

                    string query = "DELETE FROM ROL WHERE ID_ROL = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);

                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                        MessageBox.Show("🗑️ Rol eliminado correctamente");
                    else
                        MessageBox.Show("No se encontró un rol con ese Id.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al eliminar: " + ex.Message);
            }


            txtidrol.Clear();
            cmbnombrerol.Text = "";
            txtdescrip.Clear();
            txtdescrip.Focus();
        }



        // Preguntar si está seguro de salir
        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?",
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
        // esto indica que abra con la app predeterminada

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = @"C:\Users\Belen\Downloads\MANUAL ROLES.pdf",
                UseShellExecute = true 
            };
            System.Diagnostics.Process.Start(psi);
        }
        // Ruta del PDF en la carpeta del ejecutable
        private void btnayuda_Click_1(object sender, EventArgs e)
        {
            
            string rutaPdf = Path.Combine(Application.StartupPath, "MANUAL ROLES.pdf");

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

USUARIOS:


using Microsoft.Data.SqlClient; // Asegúrate de tener la referencia a Microsoft.Data.SqlClient
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace INICIO
{


    public partial class usuarios : Form
    {
        // Instancia de la clase de conexión
        private string conexiontionString;
        private ConexionBD conexionDB = new ConexionBD(); 

        public usuarios()
        {
            InitializeComponent();
        }


        //Método para cargar roles en el ComboBox
        public void CargarRoles()
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {

                    string query = "SELECT ID_ROL, NOMBRE_ROL FROM ROL";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    cmbrol.DataSource = dt;
                    cmbrol.DisplayMember = "NOMBRE_ROL";
                    cmbrol.ValueMember = "ID_ROL";
                    cmbrol.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al cargar roles: " + ex.Message);
                }
            }
        }
        // validaciones básicas
        // Si por alguna razón el ID está vacío, lo regeneramos
        // limpiar y generar ID nuevo
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtnombreusuario.Text) ||
                string.IsNullOrWhiteSpace(txtapellidousuarios.Text) ||
                string.IsNullOrWhiteSpace(txtcorreousuario.Text) ||
                string.IsNullOrWhiteSpace(txtclaveusuario.Text) ||
                cmbrol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {


                    
                    if (string.IsNullOrWhiteSpace(txtidusuario.Text))
                        GenerarNuevoId();

                    string query = @"INSERT INTO USUARIOS 
                                     (ID_USUARIO, NOMBRE, APELLIDO, CORREO, CLAVE, ID_ROL, FECHA_REGISTRO)
                                     VALUES (@ID, @NOMBRE, @APELLIDO, @CORREO, @CLAVE, @ROL, @FECHA)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt64(txtidusuario.Text));
                    cmd.Parameters.AddWithValue("@NOMBRE", txtnombreusuario.Text);
                    cmd.Parameters.AddWithValue("@APELLIDO", txtapellidousuarios.Text);
                    cmd.Parameters.AddWithValue("@CORREO", txtcorreousuario.Text);
                    cmd.Parameters.AddWithValue("@CLAVE", txtclaveusuario.Text);
                    cmd.Parameters.AddWithValue("@ROL", cmbrol.SelectedValue);
                    cmd.Parameters.AddWithValue("@FECHA", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Usuario guardado correctamente.");

                    
                    LimpiarCampos();
                    GenerarNuevoId();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al guardar: " + ex.Message);
            }
        }

        //elimna contenido o datos de los campos
        private void btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas eliminar los datos ingresados?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("🗑️ Datos eliminados correctamente.",
                    "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimpiarCampos();
        }





        // MÉTODO PARA LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            txtnombreusuario.Clear();
            txtapellidousuarios.Clear();
            txtcorreousuario.Clear();
            txtclaveusuario.Clear();
            cmbrol.Text = "";
            dtpfecha.Value = DateTime.Now;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MessageBox.Show("Operación cancelada.");
        }

        private void txtnombreusuario_TextChanged(object sender, EventArgs e)
        {

        }
        // No permitir editar el ID
        // Llamar a función que genera el ID automáticamente

        private void usuarios_Load(object sender, EventArgs e)
        {
            txtidusuario.Enabled = false;
            CargarRoles();
            dtpfecha.Value = DateTime.Now;
            txtidusuario.Enabled = false; 
            GenerarNuevoId(); 
        }
        // Función para generar el siguiente ID automáticamente
        private int ObtenerSiguienteIdUsuario()
        {
            int siguienteId = 1;

            using (SqlConnection conexion = new SqlConnection(conexiontionString))
            {
                conexion.Open();
                string consulta = "SELECT ISNULL(MAX(ID_USUARIO), 0) + 1 FROM USUARIOS";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                siguienteId = Convert.ToInt32(comando.ExecuteScalar());
            }

            return siguienteId;
        }
        //Asegurarse de que este método exista y tenga este nombre EXACTO
        private void GenerarNuevoId()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {

                    string consulta = "SELECT ISNULL(MAX(ID_USUARIO), 0) + 1 FROM USUARIOS";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    object resultado = cmd.ExecuteScalar();
                    txtidusuario.Text = (resultado != null) ? resultado.ToString() : "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar ID: " + ex.Message);
                txtidusuario.Text = "1";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // Ruta del PDF en la carpeta del ejecutable
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            
            string rutaPdf = Path.Combine(Application.StartupPath, "MANUAL USUARIOS.pdf");

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

RESPALDO Y RESTAURACION:

namespace INICIO
{
    public partial class RespaldoYrestaurar : Form
    {
        private ConexionBD conexionDB = new ConexionBD();
        public RespaldoYrestaurar()
        {
            InitializeComponent();
        }

        private void RespaldoYrestaurar_Load(object sender, EventArgs e)
        {


        }

        // Crear respaldo
        // Evento del botón que crea un respaldo (backup) de la base de datos
        // Define la ruta del archivo de respaldo en el escritorio del usuario
        // Ejecuta el comando BACKUP DATABASE para crear el archivo .bak
        // Muestra mensaje de éxito con la ubicación del respaldo o error si falla
        private void btnCrearBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string backupPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    "MECANICA_INDUSTRIAL.bak"
                );

                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = $"BACKUP DATABASE MECANICA_INDUSTRIAL TO DISK = '{backupPath}'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show($"✅ Respaldo creado correctamente en:\n{backupPath}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al crear el respaldo:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Evento del botón que restaura la base de datos desde un archivo de respaldo
        // Abre un diálogo para que el usuario seleccione el archivo .bak
        // Se conecta a la base de datos master para ejecutar la restauración
        // Pone la base de datos en modo usuario único, restaura desde el archivo y vuelve a modo multiusuario
        // Muestra mensaje de éxito o error según el resultado de la operación
        // Se usa la base "master" para ejecutar el RESTORE
        private void btnrestau_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Archivos de respaldo (*.bak)|*.bak";
                open.Title = "Selecciona un archivo de respaldo";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    string backupFile = open.FileName;

                    
                    string masterConnection = "Server=DESKTOP-8QJ2O4S\\ENIAGOMEZ;Database=master;Integrated Security=True;TrustServerCertificate=True;";

                    using (SqlConnection con = new SqlConnection(masterConnection))
                    {
                        con.Open();

                        string restoreQuery = @"
                            ALTER DATABASE MECANICA_INDUSTRIAL SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                            RESTORE DATABASE MECANICA_INDUSTRIAL FROM DISK = @backupFile WITH REPLACE;
                            ALTER DATABASE MECANICA_INDUSTRIAL SET MULTI_USER;
                        ";

                        SqlCommand cmd = new SqlCommand(restoreQuery, con);
                        cmd.Parameters.AddWithValue("@backupFile", backupFile);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("✅ Base de datos restaurada correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al restaurar el respaldo:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Ruta donde se guardará el respaldo
        // Verificar si la carpeta existe, si no, crearla
        //  Crear respaldo de la base de datos
        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                
                string carpetaRespaldo = @"C:\RespaldoSQL";
                string backupPath = Path.Combine(carpetaRespaldo, "MECANICA_INDUSTRIAL.bak");

                
                if (!Directory.Exists(carpetaRespaldo))
                {
                    Directory.CreateDirectory(carpetaRespaldo);
                }

                /
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = $"BACKUP DATABASE MECANICA_INDUSTRIAL TO DISK = '{backupPath}' WITH FORMAT, INIT;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show($"✅ Respaldo creado correctamente en:\n{backupPath}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al crear el respaldo:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Preguntar si realmente quiere salir
        // Si el usuario presiona "Sí", cerrar el formulario
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
        // Ruta del PDF en la carpeta del ejecutable
        private void btnayuda_Click(object sender, EventArgs e)
        {
            
            string rutaPdf = Path.Combine(Application.StartupPath, "MANUAL RESPALDO Y RESTAURACION.pdf");

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

DASHBOARD:


namespace INICIO
{
    public partial class Dashboard : Form
    {
        private ConexionBD conexionDB = new ConexionBD();

        public Dashboard()
        {
            InitializeComponent();

        }

        private void timerHora_Tick(object sender, EventArgs e)
        {

            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {


        }

        private Chart GetGrafica()
        {
            return grafica;
        }



        // Mostrar el menú principal de nuevo
        // Cerrar este formulario
        // Abre el formulario de contratos como diálogo modal
        // Abre el formulario de clientes como diálogo modal
        // Actualiza la etiqueta con la hora actual en formato HH:mm:ss
        // Vuelve al menú principal, abre el formulario Menu y cierra el actual
        // Minimiza la ventana del formulario
        // Cierra completamente la aplicación
        // Evento click del gráfico (sin implementación)
        // Evento de carga del Dashboard: inicializa la hora y carga el gráfico
        private void btncontratos_Click(object sender, EventArgs e)
        {
            contratos formContratos = new contratos();
            formContratos.ShowDialog();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            clientes formClientes = new clientes();
            formClientes.ShowDialog();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

        }
        
        private void btnvolver_Click(object sender, EventArgs e)
        {
            
            Menu frmMenu = new Menu();
            frmMenu.Show();

            
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void grafica_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            CargarGrafico();
        }
        // Consulta agrupada por estado
        // Limpiar gráfico
        // Crear y configurar el área del gráfico
        // Quitar márgenes para centrar el pastel
        // Esto centra y ajusta el pastel dentro del área visible
        // Crear la serie (gráfico pastel)
        // nombre + porcentaje
        // Carga datos desde SQL
        // Tonos diferentes de azul
        // Agregar serie
        // Leyenda (opcional, también centrada a la derecha)
        private void CargarGrafico()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {


                    
                    string query = "SELECT ESTADO, COUNT(*) AS TOTAL FROM PROYECTOS GROUP BY ESTADO";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    
                    grafica.Series.Clear();
                    grafica.ChartAreas.Clear();
                    grafica.Titles.Clear();
                    grafica.Legends.Clear();

                    
                    ChartArea area = new ChartArea("MainArea");
                    grafica.ChartAreas.Add(area);

                    
                    area.Position = new ElementPosition(0, 0, 100, 100);
                    area.InnerPlotPosition = new ElementPosition(25, 10, 50, 80);
                    
                    
                    Series serie = new Series("Proyectos");
                    serie.ChartType = SeriesChartType.Pie;
                    serie.IsValueShownAsLabel = true;
                    serie.Label = "#VALX\n#PERCENT{P1}"; 
                    serie.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    serie.LabelForeColor = Color.White;
                    serie["PieLabelStyle"] = "Inside";
                    serie["PieStartAngle"] = "90";

                    
                    while (dr.Read())
                    {
                        string estado = dr["ESTADO"].ToString();
                        int total = Convert.ToInt32(dr["TOTAL"]);
                        serie.Points.AddXY(estado, total);
                    }

                    
                    Color[] tonosAzules = new Color[]
                    {
                Color.FromArgb(70, 130, 180),  
                Color.FromArgb(100, 149, 237), 
                Color.FromArgb(135, 206, 235), 
                Color.FromArgb(176, 224, 230)  
                    };

                    for (int i = 0; i < serie.Points.Count; i++)
                        serie.Points[i].Color = tonosAzules[i % tonosAzules.Length];

                    
                    grafica.Series.Add(serie);

                    
                    Legend leyenda = new Legend("Estados");
                    leyenda.Docking = Docking.Right;
                    leyenda.Alignment = StringAlignment.Center;
                    leyenda.Font = new Font("Segoe UI", 9);
                    grafica.Legends.Add(leyenda);

                   
                    Title titulo = new Title("Proyectos por Estado",
                        Docking.Top,
                        new Font("Segoe UI", 12, FontStyle.Bold),
                        Color.Black);
                    titulo.Alignment = ContentAlignment.TopCenter;
                    grafica.Titles.Add(titulo);

                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Ruta del PDF en la carpeta del ejecutable 
        private void btnayuda_Click(object sender, EventArgs e)
        {
            
            string rutaPdf = Path.Combine(Application.StartupPath, "MANUAL DASHBOARD.pdf");

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

## MANUAL TECNICO MENU DE CONSULTAS

using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Windows.Forms;

namespace INICIO
{
    //Se define la clase Menuconsultas, la cual hereda de Form,
    //indicando que se trata de una ventana principal del sistema dentro del namespace INICIO.
    public partial class Menuconsultas : Form
    {
        //Esto permite trabajar con múltiples consultas dentro de una sola ventana principal.
        public Menuconsultas()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Hace que este formulario sea un contenedor MDI
        }

        private void AbrirFormulario(Form formulario)
        {
            // Cerrar cualquier formulario hijo que esté abierto
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            // Configurar el nuevo formulario como hijo del contenedor
            formulario.MdiParent = this;
            formulario.Show(); // No se cambia tamaño ni color
        }

        //Abre el formulario Salidapagos, correspondiente al módulo de:
        //Consulta de facturas
        //Consulta de pago
//Exportación de reportes financieros
        private void btnfacturacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Salidapagos());
        }

        //Carga el formulario de Consulta de Proyectos, donde se gestionan:
        //Proyectos
        //Seguimientos
//Contratos
//Procesos
        private void btnpro_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ConsultaProyectos());
        }

        //Abre el módulo de Consulta de Servicios, permitiendo visualizar y exportar información de servicios prestados.
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ConsultaServicio());
        }

        //Carga el formulario de Consulta de Inventario, donde se pueden revisar y exportar datos relacionados con el inventario de productos.
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ConsultaInventario());
        }

        //Vuelve al menú principal de la aplicación.
        private void btnvolver_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();
            this.Close();
        }
        //Cierra completamente la aplicación.
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Minimiza la ventana actual a la barra de tareas.
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Evento Load del formulario Menuconsultas
        private void Menuconsultas_Load(object sender, EventArgs e)
        {

        }
    }
}

