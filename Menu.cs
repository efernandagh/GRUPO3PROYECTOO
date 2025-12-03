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

