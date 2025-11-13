using System;
using System.Windows.Forms;

namespace INICIO
{
    public partial class Menuconsultas : Form
    {
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

        private void btnfacturacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Salidapagos());
        }

        private void btnpro_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ConsultaProyectos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ConsultaServicio());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ConsultaInventario());
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Menuconsultas_Load(object sender, EventArgs e)
        {

        }
    }
}
