using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace INICIO
{
    public partial class Form1 : Form

    {
        private ConexionBD conexionDB = new ConexionBD();

        public Form1()
        {
            InitializeComponent();


          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Centrar todo el grupo de controles
            int centerX = (this.ClientSize.Width - barratitulo.Width) / 2;
            int centerY = (this.ClientSize.Height - barratitulo.Height) / 2;
            barratitulo.Location = new Point(centerX, centerY);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text.Trim();
            string contra = txtcontra.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contra))
            {
                MessageBox.Show("Debe ingresar usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = "SELECT COUNT(*) FROM USUARIOS WHERE NOMBRE = @nombre AND CLAVE = @clave";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@clave", contra);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Inicio de sesión exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Menu frmMenu = new Menu();
                        frmMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos:\n" + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtnombre.Clear();

            txtcontra.Clear();


            txtnombre.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            button1.Visible = false;
            btnrestaurar.Visible = true;

        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            button1.Visible = true;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
