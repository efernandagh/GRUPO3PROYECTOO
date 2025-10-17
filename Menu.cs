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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

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

        private void btnproyectos_Click(object sender, EventArgs e)
        {
            Submenuproyectos.Visible = true;
        }

        private void btnproyectoinventario_Click(object sender, EventArgs e)
        {
            Submenuproyectos.Visible = false;
        }

        private void btnseguimiento_Click(object sender, EventArgs e)
        {
            Submenuproyectos.Visible = false;
        }

        private void btncontratos_Click(object sender, EventArgs e)
        {
            Submenuproyectos.Visible = false;
        }

        private void btnprocesos_Click(object sender, EventArgs e)
        {
            Submenuproyectos.Visible = false;
        }

        private void btnservicios_Click(object sender, EventArgs e)
        {
            Submenuservicios.Visible = true;
        }

        private void btnservicios2_Click(object sender, EventArgs e)
        {
            Submenuservicios.Visible = false;
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            Submenuservicios.Visible = false;
        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            submenuinvenatario.Visible = true;
        }

        private void btninventario2_Click(object sender, EventArgs e)
        {
            submenuinvenatario.Visible = false;
        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            submenuinvenatario.Visible = false;
        }

        private void btnfacturacion_Click(object sender, EventArgs e)
        {
            submenufacturacion.Visible = true;
        }

        private void btnfacturas_Click(object sender, EventArgs e)
        {
            submenufacturacion.Visible = false;
            AbrirFormulario(new facturas());
        }

        private void btnpagos_Click(object sender, EventArgs e)
        {
            submenufacturacion.Visible = false;
            AbrirFormulario(new frmPagos());
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            ssubmenuadmin.Visible = true;
        }

        private void btnroles_Click(object sender, EventArgs e)
        {
            ssubmenuadmin.Visible = false;
            AbrirFormulario(new roles());
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            ssubmenuadmin.Visible = false;
            AbrirFormulario(new usuarios());
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

}

