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

 ## PANTALLAS PRINCIPALES
  ![Imagen de WhatsApp 2025-12-03 a las 09 24 13_27e1862c](https://github.com/user-attachments/assets/2bb05702-773a-4f81-91df-70e1192271af)

  ![Imagen de WhatsApp 2025-12-03 a las 09 24 33_e51cfbf3](https://github.com/user-attachments/assets/d40b634c-bcd1-4afd-93af-6a18aa41901d)

  ![Imagen de WhatsApp 2025-12-03 a las 09 24 55_8905a176](https://github.com/user-attachments/assets/a54f57f9-d61b-4078-b957-71cc36f5718e)




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
## MANUAL TECNICO CONSULTA DE PROYECTOS
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClosedXML.Excel.XLPredefinedFormat;
using static System.Resources.ResXFileRef;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace INICIO
{

    //Define el formulario ConsultaProyectos, perteneciente al espacio de nombres INICIO.
    //Este formulario se encarga de realizar consultas dinámicas sobre varias tablas del sistema.
    public partial class ConsultaProyectos : Form
    {
        //Inicializa todos los controles gráficos definidos en el diseñador (ComboBox, DataGridView, botones, etc.).
        public ConsultaProyectos()
        {
            InitializeComponent();
        }

        //Preparar el entorno de búsqueda antes de que el usuario interactúe.
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

        // Se cargan sus columnas en el cbobuscar para permitir búsquedas dinámicas sin escribir consultas manualmente.
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

        //  Cuando cambia el campo "Buscar"
        //Se cargan automáticamente sus valores únicos desde la base de datos.
        //Esto permite búsquedas por lista sin escribir texto manual.
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
                    //llena el cbDescripcion con los valores únicos existentes en la base de datos.
                    //Evita duplicados y evita errores de escritura por parte del usuario.
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
        //Esto permite búsquedas automáticas sin necesidad de escribir consultas SQL.
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
                    //Detecta automáticamente si el valor es una fecha o texto
                    string query = $"SELECT * FROM {tabla} WHERE {columna} = @valor";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Detectamos si el valor es fecha
                    DateTime fechaConvertida;
                    if (DateTime.TryParse(valor, out fechaConvertida))
                    {
                        cmd.Parameters.Add("@valor", SqlDbType.Date).Value = fechaConvertida.Date;
                    }
                    else
                    {
                        cmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                    }

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

        }

        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {

        }

        //Muestra un mensaje de confirmación antes de cerrar el formulario.
        //Previene cierres accidentales del sistema.
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

        //Valida que existan datos en el DataGridView.
      //  Convierte los datos a DataTable.
       // Solicita la ruta mediante SaveFileDialog.
        //Exporta el archivo usando ClosedXML.
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

        //Genera un archivo PDF en formato horizontal.
        //Agrega un título dinámico con el nombre de la tabla.
        //Crea una tabla con los datos del DataGridView.
        //Aplica formato a encabezados.
      //  Guarda el archivo automáticamente.
        private void ExportarPDF()
        {
            if (dtvproyectos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Archivo PDF|*.pdf";
                sfd.FileName = "ConsultaExportada.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Crear documento PDF
                    Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    // Título
                    Paragraph titulo = new Paragraph("Resultados de Consulta - " + cbotabla.Text,
                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, BaseColor.BLACK));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.SpacingAfter = 20;
                    doc.Add(titulo);

                    // Crear tabla PDF con el mismo número de columnas
                    PdfPTable pdfTable = new PdfPTable(dtvproyectos.Columns.Count);
                    pdfTable.WidthPercentage = 100;

                    // Agregar encabezados
                    foreach (DataGridViewColumn column in dtvproyectos.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.WHITE)));
                        cell.BackgroundColor = new BaseColor(0, 102, 204); // Azul suave
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.AddCell(cell);
                    }

                    // Agregar filas
                    foreach (DataGridViewRow row in dtvproyectos.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(new Phrase(cell.Value?.ToString() ?? ""));
                            }
                        }
                    }

                    doc.Add(pdfTable);
                    doc.Close();

                    MessageBox.Show("PDF exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar PDF: " + ex.Message);
            }
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            ExportarPDF();
        }

        //Permite abrir el Manual de Usuario en PDF
        private void btnayuda_Click(object sender, EventArgs e)
        {
            // Ruta del PDF en la carpeta del ejecutable
            string rutaPdf = Path.Combine(Application.StartupPath, "Manual de usuario proyectos.pdf");

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
## MANUAL TECNICO CONSULTA DE SERVICIOS

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

## MANUAL TECNICO CONSULTA DE INVENTARIOS
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

namespace INICIO
{
    //Representa el módulo encargado de consultar información de inventarios y proveedores, con opciones de búsqueda, filtrado y exportación.
   
    public partial class ConsultaInventario : Form
    {
        //Inicializa todos los controles gráficos definidos en el diseñador.
        public ConsultaInventario()
        {
            InitializeComponent();
        }
        //Limpia el ComboBox de tablas, Carga las tablas:
        //INVENTARIOS
        // PROVEEDORES
        //Selecciona automáticamente la primera opción. Carga:Columnas disponibles,Datos completos en el DataGridView.
        //Prepara el entorno de consultas al abrir el formulario.
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

        //Muestra una confirmación de salida mediante MessageBox.
        //Si el usuario confirma, se cierra el formulario.
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

        //Realiza un SELECT DISTINCT sobre la columna seleccionada.
        //Llena el ComboBox cmbdescripcion con valores únicos.
        //Permite seleccionar datos reales existentes en la base.
        //Facilita la búsqueda sin que el usuario escriba manualmente.
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
        //Permite mostrar todos los registros disponibles sin filtros.
        private void CargarDatos(string tabla)
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    //Ejecuta un SELECT * FROM tabla.
                    string query = $"SELECT * FROM {tabla}";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    //Llena un DataTable
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                   // Asigna los datos al DataGridView.
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


        //Permite iniciar una nueva consulta desde cero
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            cmbbuscar.SelectedIndex = 0;
            cmbdescripcion.SelectedIndex = 0;
            dgvinventario.DataSource = null;
        }
        //Permite realizar búsquedas parciales por texto.
        //Valida que el campo no esté vacío.//Ejecuta un SELECT usando LIKE.
        //Muestra los resultados en el DataGridView.
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
        //Carga automáticamente todas las opciones al abrir el formulario.
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
        //Detecta automáticamente el tipo de dato:Fecha,Entero,Decimal,Texto
        //Ejecuta la consulta adecuada según el tipo.

        //Muestra los resultados filtrados.

       // Si no hay resultados, notifica al usuario.
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
        //Generación de reportes en formato Excel para control administrativo.
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
        //Permite acceso a documentación del usuario final.
        private void btnpdf_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (dgvinventario.Rows.Count == 0)
                    {
                        MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (dgvinventario.Columns.Count == 0)
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
                        int columnas = dgvinventario.Columns.Count;
                        PdfPTable tabla = new PdfPTable(columnas);
                        tabla.WidthPercentage = 100;

                        // Encabezados de columnas
                        var headerFont = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD);
                        foreach (DataGridViewColumn col in dgvinventario.Columns)
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
                        foreach (DataGridViewRow fila in dgvinventario.Rows)
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

        private void btnayuda_Click(object sender, EventArgs e)
        {
            // Ruta del PDF en la carpeta del ejecutable
            string rutaPdf = Path.Combine(Application.StartupPath, "Manual de usuario consulta inventario.pdf");

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

## MANUAL TECNICO CONSULTA DE FACTURACION
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient;
using Microsoft.Win32;
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
using static System.Resources.ResXFileRef;

//Este formulario permite la consulta, filtrado y exportación de datos de pagos y facturas del sistema C-MISUR.
//Además, permite generar reportes en Excel y PDF, así como acceder al manual de usuario.
namespace INICIO
{

    public partial class Salidapagos : Form
    {
        //Define el formulario de control de pagos y facturas,
        //que permite la consulta avanzada de información financiera del sistema.
        public Salidapagos()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {



        }




        //Restablece el formulario:
       // Reinicia los ComboBox.
        //Limpia el DataGridView dtvpagos.
        //Evita inconsistencias en búsquedas anteriores.
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            cmbtabla.SelectedIndex = 0;
            cmbdescrip.SelectedIndex = 0;
            dtvpagos.DataSource = null; ;
        }
        //Esto prepara automáticamente el entorno de consulta al abrir el formulario.
        private void Salidapagos_Load(object sender, EventArgs e)
        {
            cmbtabla.Items.AddRange(new string[] { "FACTURAS", "PAGOS" });
            cmbtabla.SelectedIndex = 0;
            CargarColumnas("FACTURAS");
            CargarValoresDescripcion("FACTURAS", cbobuscar.SelectedItem.ToString());
            CargarDatos();
        }

        //Carga los valores únicos de la columna seleccionada en el ComboBox descripción
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

        //ste método es de tipo privado y no devuelve ningún valor.
        //Su función principal es la carga dinámica de datos desde SQL Server hacia la interfaz gráfica.
        private void CargarDatos()
        {
            try
            //Se utiliza un bloque try-catch para capturar cualquier error durante la consulta, evitando que el sistema se cierre inesperadamente.
            {
                //Se establece una conexión a SQL Server mediante la clase ConexionBD.
                //El uso de using garantiza que la conexión se cierre correctamente al finalizar el proceso.
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    //Se obtienen los valores seleccionados en los ComboBox:
                    string tabla = cmbtabla.Text;
                    string columna = cbobuscar.Text;
                    string valor = cmbdescrip.Text;

                    //Se construye una consulta base que obtiene todos los registros de la tabla seleccionada.
                    string query = $"SELECT * FROM {tabla}";

                    if (!string.IsNullOrEmpty(valor))
                    {
                        if (columna.Contains("FECHA"))
                        {
                            //Convierte la fecha para evitar errores de formato y compara solo la parte de la fecha.
                            query += $" WHERE CONVERT(date, {columna}) = '{valor}'";
                        }
                        else
                        {
                            //Permite búsquedas parciales usando el operador LIKE.
                            query += $" WHERE {columna} LIKE '%{valor}%'";
                        }
                    }

                    //Esto muestra automáticamente los resultados al usuario.
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

        //El método InicializarCombos() se encarga de configurar y cargar los valores iniciales del ComboBox cmbtabla
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

        //Carga dinámicamente las columnas dependiendo la tabla seleccionada
        //Carga dinámicamente las columnas dependiendo la tabla seleccionada
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

        //Este evento se ejecuta cuando el usuario presiona el botón “Cargar” del formulario.
        //Su función principal es actualizar y mostrar los registros en el DataGridView según los filtros actualmente seleccionados(tabla, campo y valor).
        private void btncargar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }



        private void dtvpagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Este es un método manejador de evento, el cual se activa cuando el usuario cambia la selección del ComboBox.
        private void cbobuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarValoresDescripcion(cmbtabla.Text, cbobuscar.Text);
        }


        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        //Se recargan las columnas.
       // Se recargan los valores de búsqueda.
        //Se actualiza el DataGridView automáticamente.
        private void cmbtabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarColumnas(cmbtabla.Text);
            CargarValoresDescripcion(cmbtabla.Text, cbobuscar.Text);
            CargarDatos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Detecta automáticamente el tipo de dato
        //Y ejecuta una consulta parametrizada para mayor seguridad
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

        //Valida que existan datos.
        //Convierte el DataGridView en un DataTable.
       // Solicita la ruta de guardado.
       // Exporta usando ClosedXML.
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


        //Crea documento PDF.
        //Agrega encabezado institucional de C-MISUR.
        //Genera tabla dinámica con los datos.
        //Aplica formato a encabezados y celdas.
        //Guarda el archivo automáticamente.

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

        //Muestra una confirmación antes de cerrar el formulario, evitando salidas accidentales.
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

        //Permite abrir el Manual de Usuario desde la carpeta del ejecutable
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

## MANUAL TECNICO INVENTARIO
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
    public partial class inventario : Form
    {
        //Instancia para manejar la conexión
        private ConexionBD conexionDB = new ConexionBD();
        private string conexiontionString;

        
        //Carga los componentes del formulario
        public inventario()
        {
            InitializeComponent();
        }
        // ✅ Cargar valores únicos de UNIDAD_MEDIDA en el ComboBox
        private void CargarUnidades()
        {
            // Realiza la carga de unidades de medida desde la base de datos
            try
            {
                cmbunidad.Items.Clear(); // Limpiar por si se vuelve a cargar

                using (SqlConnection conn = Conectar())
                {
                    string query = "SELECT DISTINCT UNIDAD_MEDIDA FROM INVENTARIOS WHERE UNIDAD_MEDIDA IS NOT NULL";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbunidad.Items.Add(reader["UNIDAD_MEDIDA"].ToString()); // Agregar solo valores únicos
                    }
                }

                if (cmbunidad.Items.Count == 0) 
                {
                    MessageBox.Show("No se encontraron unidades de medida en la tabla INVENTARIOS.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar unidades de medida: " + ex.Message);
            }
        }

        // 🔸 Función para abrir la conexión a la base de datos
        private SqlConnection AbrirConexion()
        {
            return ConexionBD.ObtenerConexion();
        }
        // 🔸 Cargar ComboBox con los servicios al iniciar
        private void servicios_Load(object sender, EventArgs e)
        {
            // Cargar unidades de medida en el ComboBox al cargar el formulario

            using (SqlConnection conn = Conectar())
            {
                string query = "SELECT UNIDAD_MEDIDA FROM INVENTARIOS";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) 
                {
                    cmbunidad.Items.Add(reader["UNIDAD_MEDIDA"].ToString());
                }

                conn.Close();
            }
        }

        //Centraliza el acceso a la base de datos y permite reutilización y mantenimiento más fácil
        //🔸 Función para abrir la conexión a la base de datos
        private SqlConnection Conectar()
        {
            return ConexionBD.ObtenerConexion();
        }

        // Configuración inicial al cargar el formulario
        private void inventario_Load(object sender, EventArgs e)
        {
            txtidinventario.Enabled = false;
            GenerarNuevoId();
            CargarUnidades();
        }

        // Guarda un nuevo inventario en la base de datos
        private void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conectar())
            {
                string query = "INSERT INTO INVENTARIOS (ID_INVENTARIO, NOMBRE_PRODUCTO, CANTIDAD, UNIDAD_MEDIDA, FECHA_INGRESO, ESTADO, ID_PROVEEDOR) VALUES (@id, @nombre, @cantidad, @unidad, @fecha, @estado, @ID_PROVEEDOR)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt64(txtidinventario.Text));
                cmd.Parameters.AddWithValue("@nombre", txtnombrepro.Text);
                cmd.Parameters.AddWithValue("@cantidad", txtcantidad.Text);
                cmd.Parameters.AddWithValue("@unidad", cmbunidad.Text);
                cmd.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dtpfecha.Text));
                cmd.Parameters.AddWithValue("@estado", txtestado.Text);
                cmd.Parameters.AddWithValue("@ID_PROVEEDOR", Convert.ToInt64(txtidpro.Text));

                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inventario guardado correctamente.");
                conn.Close();
            }
        }

        // Limpia todos los campos del formulario para editar un inventario existente
        private void btneditar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            txtidinventario.Clear();
            txtnombrepro.Text = "";
            txtcantidad.Clear();
            cmbunidad.Items.Clear();
            dtpfecha.Text = "";
            txtestado.Clear();
            txtidpro.Clear();


            // Poner el foco en el primer campo
            txtidinventario.Focus();

            MessageBox.Show("Formulario limpiado", "Limpiar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // Función para limpiar todos los campos del formulario 
        private void LimpiarCampos()
        {
            txtidinventario.Clear();
            txtnombrepro.Text = "";
            txtcantidad.Clear();
            cmbunidad.Items.Clear();
            dtpfecha.Text = "";
            txtestado.Clear();
            txtidpro.Clear();

        }

        // Limpia los campos al hacer clic en el botón "Limpiar"
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Cierra el formulario al hacer clic en el botón "Cancelar"
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Guarda un nuevo inventario en la base de datos al hacer clic en el botón "Nuevo"
        private void btnnuevo_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = Conectar())
                {
                    string query = @"INSERT INTO INVENTARIOS 
                    (ID_INVENTARIO, NOMBRE_PRODUCTO, CANTIDAD, UNIDAD_MEDIDA, FECHA_INGRESO, ESTADO, ID_PROVEEDOR) 
                    VALUES (@id, @nombre, @cantidad, @unidad, @fecha, @estado, @ID_PROVEEDOR)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt64(txtidinventario.Text));
                    cmd.Parameters.AddWithValue("@nombre", txtnombrepro.Text);
                    cmd.Parameters.AddWithValue("@cantidad", txtcantidad.Text);
                    cmd.Parameters.AddWithValue("@unidad", cmbunidad.Text);
                    cmd.Parameters.AddWithValue("@fecha", dtpfecha.Value);
                    cmd.Parameters.AddWithValue("@estado", txtestado.Text);
                    cmd.Parameters.AddWithValue("@ID_PROVEEDOR", Convert.ToInt64(txtidpro.Text));

                    cmd.ExecuteNonQuery();
                }
                
                MessageBox.Show("✅ Inventario guardado correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar inventario: " + ex.Message);
            }
        }

        // ✅ Función para generar el siguiente ID automáticamente
        private int ObtenerSiguienteIdUsuario()
        {
            int siguienteId = 1;

            using (SqlConnection conexion = new SqlConnection(conexiontionString))
            {
                conexion.Open();
                string consulta = "SELECT ISNULL(MAX(ID_INVENTARIO), 0) + 1 FROM INVENTARIOS";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                siguienteId = Convert.ToInt32(comando.ExecuteScalar());
            }

            return siguienteId;
        }

        // ✅ Genera un nuevo ID para el inventario al cargar el formulario
        private void GenerarNuevoId()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion()) // Abrir conexión
                {

                    string consulta = "SELECT ISNULL(MAX(ID_INVENTARIO), 0) + 1 FROM INVENTARIOS";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    object resultado = cmd.ExecuteScalar();
                    txtidinventario.Text = (resultado != null) ? resultado.ToString() : "1";
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show("❌ Error al generar ID: " + ex.Message); // Mostrar mensaje de error
                txtidinventario.Text = "1";
            }
        }

      
        private void label7_Click(object sender, EventArgs e)
        {

        }

        // Abre el manual de inventario en PDF al hacer clic en el botón de ayuda
        private void btnayuda_Click(object sender, EventArgs e)
        {
            // Ruta del PDF en la carpeta del ejecutable
            string rutaPdf = Path.Combine(Application.StartupPath, "Manual d Inventario.pdf");

            if (File.Exists(rutaPdf))
            {
                // Abre el PDF con la aplicación predeterminada del sistema
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

   ## MANUAL TECNICO SERVICIOS
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
    public partial class servicios : Form // Clase parcial para el formulario de servicios
    {
        private ConexionBD conexionDB = new ConexionBD(); // Instancia de la clase de conexión
        private string conexion; // Cadena de conexión a la base de datos
        private string conexiontionString;


        
        public servicios() // Constructor del formulario
        {
            InitializeComponent();
        }
        private SqlConnection Conectar() // Función para conectar a la base de datos
        {
            SqlConnection conn = new SqlConnection(conexion);
            conn.Open();
            return conn;
        }

        // 🔸 Cargar ComboBox con los servicios al iniciar
        private void servicios_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conectar()) 
            {
                // Cargar los nombres de los servicios en el ComboBox
                string query = "SELECT NOMBRE_SERVICIO FROM SERVICIOS";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                // Limpiar los ítems actuales
                while (reader.Read()) 
                {
                    txtnombreser.Items.Add(reader["NOMBRE_SERVICIO"].ToString());
                }

                conn.Close();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        // Salir del formulario
        private void button2_Click(object sender, EventArgs e)
        {// Preguntar si está seguro de salir
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?",
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void txtnombredelservicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtdesc_TextChanged(object sender, EventArgs e)
        {

        }

        // Guardar nuevo servicio en la base de datos
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion()) 
            {
                string query = "INSERT INTO SERVICIOS (ID_SERVICIOS, NOMBRE_SERVICIO, DESCRIPCION) VALUES (@id, @nombre, @descripcion)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtidservicio.Text);
                cmd.Parameters.AddWithValue("@nombre", txtnombreser.Text);
                cmd.Parameters.AddWithValue("@descripcion", txtdesc.Text);


                MessageBox.Show("Servicio guardado correctamente.");
                con.Close();
            }
        }


        // Limpiar formulario para nuevo servicio
        private void btneditar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            txtidservicio.Clear();
            txtnombreser.Text = "";
            txtdesc.Clear();


            // Poner el foco en el primer campo
            txtidservicio.Focus();

            MessageBox.Show("Formulario limpiado", "Limpiar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        // ✅ Función para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtidservicio.Clear();
            txtnombreser.Text = "";
            txtdesc.Clear();
        }

        // 🔹 Evento Load del formulario para inicializar componentes
        private void servicios_Load_1(object sender, EventArgs e)
        {
            txtidservicio.Enabled = false; // No permitir editar el ID
            GenerarNuevoId(); // 🔹 Llamar a función que genera el ID automáticamente
        }
        // ✅ Función para generar el siguiente ID automáticamente
        private int ObtenerSiguienteIdUsuario() 
        {
            int siguienteId = 1;
            
            using (SqlConnection conexion = new SqlConnection(conexiontionString)) 
            {
                conexion.Open();
                string consulta = "SELECT ISNULL(MAX(ID_SERVICIOS), 0) + 1 FROM SERVICIOS";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                siguienteId = Convert.ToInt32(comando.ExecuteScalar());
            }

            return siguienteId;
        }

        // 🔹 Función para generar un nuevo ID de servicio
        private void GenerarNuevoId()
        {
            try
            {
                // Conectar a la base de datos y obtener el siguiente ID
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    // Consulta SQL para obtener el siguiente ID disponible
                    string consulta = "SELECT ISNULL(MAX(ID_USUARIO), 0) + 1 FROM USUARIOS";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    object resultado = cmd.ExecuteScalar();
                    txtidservicio.Text = (resultado != null) ? resultado.ToString() : "1";
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("❌ Error al generar ID: " + ex.Message);
                txtidservicio.Text = "1";
            }
        }

        // Abrir el manual de usuario en PDF
        private void btnayuda_Click(object sender, EventArgs e)
        {
            // Ruta del PDF en la carpeta del ejecutable
            string rutaPdf = Path.Combine(Application.StartupPath, "Manual de Servicios.pdf");

            if (File.Exists(rutaPdf))
            {
                try
                {
                    // Abrir el PDF con la aplicación predeterminada del sistema
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = rutaPdf,
                        UseShellExecute = true
                    };
                    Process.Start(psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo abrir el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Notificar si hay un error al abrir el PDF
                }
            }
            else 
            {
                MessageBox.Show("No se encontró el archivo PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Notificar si no se encuentra el archivo
            }
        }
    }
}





