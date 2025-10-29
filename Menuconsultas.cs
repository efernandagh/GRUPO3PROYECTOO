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
    public partial class Menuconsultas : Form
    {
        public Menuconsultas()
        {
            InitializeComponent();
        }

        private void btnfacturacion_Click(object sender, EventArgs e)
        {
            Salidapagos frm = new Salidapagos();
            frm.Show(); // ← esto muestra el formulario

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            // Mostrar el menú principal de nuevo
            Menu frmMenu = new Menu();
            frmMenu.Show();

            // Cerrar este formulario
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnpro_Click(object sender, EventArgs e)
        {
            ConsultaProyectos frm = new ConsultaProyectos();
            frm.Show(); // ← esto muestra el formulario
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
