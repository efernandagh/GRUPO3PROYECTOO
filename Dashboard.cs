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
            CargarGrafico();
        }

        private void CargarGrafico()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {


                    // 🔹 Consulta agrupada por estado
                    string query = "SELECT ESTADO, COUNT(*) AS TOTAL FROM PROYECTOS GROUP BY ESTADO";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    // 🔹 Limpiar gráfico
                    grafica.Series.Clear();
                    grafica.ChartAreas.Clear();
                    grafica.Titles.Clear();
                    grafica.Legends.Clear();

                    // 🔹 Crear y configurar el área del gráfico
                    ChartArea area = new ChartArea("MainArea");
                    grafica.ChartAreas.Add(area);

                    // Quitar márgenes para centrar el pastel
                    area.Position = new ElementPosition(0, 0, 100, 100);
                    area.InnerPlotPosition = new ElementPosition(25, 10, 50, 80);
                    // ↑ Esto centra y ajusta el pastel dentro del área visible

                    // 🔹 Crear la serie (gráfico pastel)
                    Series serie = new Series("Proyectos");
                    serie.ChartType = SeriesChartType.Pie;
                    serie.IsValueShownAsLabel = true;
                    serie.Label = "#VALX\n#PERCENT{P1}"; // nombre + porcentaje
                    serie.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    serie.LabelForeColor = Color.White;
                    serie["PieLabelStyle"] = "Inside";
                    serie["PieStartAngle"] = "90";

                    // 🔹 Cargar datos desde SQL
                    while (dr.Read())
                    {
                        string estado = dr["ESTADO"].ToString();
                        int total = Convert.ToInt32(dr["TOTAL"]);
                        serie.Points.AddXY(estado, total);
                    }

                    // 🔹 Tonos diferentes de azul
                    Color[] tonosAzules = new Color[]
                    {
                Color.FromArgb(70, 130, 180),  // SteelBlue
                Color.FromArgb(100, 149, 237), // CornflowerBlue
                Color.FromArgb(135, 206, 235), // SkyBlue
                Color.FromArgb(176, 224, 230)  // PowderBlue
                    };

                    for (int i = 0; i < serie.Points.Count; i++)
                        serie.Points[i].Color = tonosAzules[i % tonosAzules.Length];

                    // 🔹 Agregar serie
                    grafica.Series.Add(serie);

                    // 🔹 Leyenda (opcional, también centrada a la derecha)
                    Legend leyenda = new Legend("Estados");
                    leyenda.Docking = Docking.Right;
                    leyenda.Alignment = StringAlignment.Center;
                    leyenda.Font = new Font("Segoe UI", 9);
                    grafica.Legends.Add(leyenda);

                    // 🔹 Título centrado
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}





