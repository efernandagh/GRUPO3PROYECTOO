using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


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
            // Mostrar el menú principal de nuevo
            Menu frmMenu = new Menu();
            frmMenu.Show();

            // Cerrar este formulario
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
            CargarGrafico   ();
        }

        private void CargarGrafico()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    

                    // Consultas SQL
                    SqlCommand cmdProy = new SqlCommand("SELECT COUNT(*) FROM PROYECTOS", con);
                    SqlCommand cmdCont = new SqlCommand("SELECT COUNT(*) FROM CONTRATOS", con);
                    SqlCommand cmdCli = new SqlCommand("SELECT COUNT(*) FROM CLIENTES", con);
                    SqlCommand cmdFact = new SqlCommand("SELECT SUM(MONTO_TOTAL) FROM FACTURAS", con);

                    // Ejecución
                    int proyectos = Convert.ToInt32(cmdProy.ExecuteScalar());
                    int contratos = Convert.ToInt32(cmdCont.ExecuteScalar());
                    int clientes = Convert.ToInt32(cmdCli.ExecuteScalar());

                    object totalFact = cmdFact.ExecuteScalar();
                    decimal facturas = (totalFact != DBNull.Value) ? Convert.ToDecimal(totalFact) : 0;

                    // 🔹 Configurar gráfico
                    grafica.Series.Clear();
                    grafica.ChartAreas.Clear();

                    ChartArea area = new ChartArea("MainArea");
                    grafica.ChartAreas.Add(area);

                    Series serie = new Series("Totales");
                    serie.ChartType = SeriesChartType.Column; // Puede ser Pie, Bar, etc.
                    serie.Points.AddXY("Proyectos", proyectos);
                    serie.Points.AddXY("Contratos", contratos);
                    serie.Points.AddXY("Clientes", clientes);
                    serie.Points.AddXY("Facturas", facturas);

                    serie.Color = Color.CornflowerBlue;
                    serie.IsValueShownAsLabel = true;

                    grafica.Series.Add(serie);

                    grafica.Titles.Clear();
                    grafica.Titles.Add("Resumen General");
                    grafica.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 
    }
}





