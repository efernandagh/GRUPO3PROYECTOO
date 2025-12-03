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





