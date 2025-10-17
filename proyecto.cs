using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace INICIO
{
    public partial class proyecto : Form
    {
        private ConexionBD conexionDB = new ConexionBD();
        private string conexiontionString;

        private void usuarios_Load(object sender, EventArgs e)
        {
            // 🔹 Cargar usuarios al iniciar el formulario
            try
            {
                

                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    

                    string query = "SELECT ID_USUARIO FROM USUARIOS";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbUsuario.Items.Clear();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("ℹ️ No se encontraron usuarios en la base de datos.",
                                        "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    while (reader.Read())
                    {
                        cbUsuario.Items.Add(reader["ID_USUARIO"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("❌ Error SQL al cargar usuarios:\n" + ex.Message,
                                "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error general al cargar usuarios:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Desactivar()
        {
            

        }
        public void Activar()
        {
            Txtidproyecto.Enabled = true;
            Txtnombrepro.Enabled = true;
            Txtestado.Enabled = true;
            cbUsuario.Enabled = true;
            Txtdescripcion.Enabled = true;
            txtfi.Enabled = true;
            txtff.Enabled = true;
            btnLimpiar.Enabled = true;
            button1.Enabled = true;


        }
        private ConexionBD conexionBD = new ConexionBD(); // Instancia de la clase de conexión
        public void Almacenar()
        {

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    

                    string sql = "INSERT INTO PROYECTOS (ID_PROYECTO, NOMBRE_PROYECTO, DESCRIPCION, FECHA_INICIO, FECHA_FIN, ESTADO, ID_USUARIO) " +
                                 "VALUES (@ID_PROYECTO, @NOMBRE_PROYECTO, @DESCRIPCION, @FECHA_INICIO, @FECHA_FIN, @ESTADO, @ID_USUARIO)";

                    using (SqlCommand command = new SqlCommand(sql, conexion))
                    {
                        command.Parameters.AddWithValue("@ID_PROYECTO", Txtidproyecto.Text);
                        command.Parameters.AddWithValue("@NOMBRE_PROYECTO", Txtnombrepro.Text);
                        command.Parameters.AddWithValue("@DESCRIPCION", Txtdescripcion.Text);
                        command.Parameters.AddWithValue("@FECHA_INICIO", dtpinicio.Value);
                        command.Parameters.AddWithValue("@FECHA_FIN", dtpfin.Value);
                        command.Parameters.AddWithValue("@ESTADO", Txtestado.Text);
                        command.Parameters.AddWithValue("@ID_USUARIO", Convert.ToInt32(cbUsuario.SelectedItem)); ;

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Proyecto agregado exitosamente.",
                        "Hola SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public proyecto()
        {
            InitializeComponent();
            Desactivar();
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            Almacenar();
        }

        private void proyecto_Load(object sender, EventArgs e)
        {
            Txtidproyecto.Enabled = false; // No permitir editar el ID
            GenerarNuevoId(); // 🔹 Llamar a función que genera el ID automáticamente
            // 🔹 Cargar usuarios al iniciar el formulario
            try
            {
                

                using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    

                    string query = "SELECT ID_USUARIO FROM USUARIOS";
                    SqlCommand cmd = new SqlCommand(query, conexion); // conexion es tu SqlConnection
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbUsuario.Items.Clear();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("ℹ️ No se encontraron usuarios en la base de datos.",
                                        "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    while (reader.Read())
                    {
                        cbUsuario.Items.Add(reader["ID_USUARIO"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("❌ Error SQL al cargar usuarios:\n" + ex.Message,
                                "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error general al cargar usuarios:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Almacenar();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Txtidproyecto.Clear();
            Txtnombrepro.Clear();


            Txtestado.Clear();
            cbUsuario.SelectedIndex = -1;

            
            Txtdescripcion.Clear();
            txtfi.Clear();
            txtff.Clear();



            // Mensaje de confirmación
            MessageBox.Show("Todos los campos han sido limpiados", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Activar();
        }

        // ✅ Función para generar el siguiente ID automáticamente
        private int ObtenerSiguienteIdUsuario()
        {
            int siguienteId = 1;

            using (SqlConnection conexion = new SqlConnection(conexiontionString))
            {
                conexion.Open();
                string consulta = "SELECT ISNULL(MAX(ID_PROYECTO), 0) + 1 FROM PROYECTOS";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                siguienteId = Convert.ToInt32(comando.ExecuteScalar());
            }

            return siguienteId;
        }

        private void GenerarNuevoId()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {

                    string consulta = "SELECT ISNULL(MAX(ID_PROYECTO), 0) + 1 FROM PROYECTOS";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    object resultado = cmd.ExecuteScalar();
                    Txtidproyecto.Text = (resultado != null) ? resultado.ToString() : "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar ID: " + ex.Message);
                Txtidproyecto.Text = "1";
            }
        }
    }
}