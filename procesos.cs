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
    public partial class Procesos : Form
    {
        private ConexionBD conexionDB = new ConexionBD();
        private string conexiontionString;


        public Procesos()
        {
            InitializeComponent();
            Desactivar();
        }
       
        private void procesos_Load(object sender, EventArgs e)
        {
            txtIdPro.Enabled = false;
            GenerarNuevoId();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Activar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdPro.Clear();
            txtNomb.Clear();
            txtdescr.Clear();
            cbUsuario.SelectedIndex = -1;


            // Mensaje de confirmación
            MessageBox.Show("Todos los campos han sido limpiados", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Desactivar()
        {
            


        }
        public void Activar()
        {
            txtIdPro.Enabled = true;
            txtNomb.Enabled = true;
            txtdescr.Enabled = true;
            cbUsuario.Enabled = true;
            btnGuardar.Enabled = true;
            btnLimpiar.Enabled = true;


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

        private ConexionBD conexionBD = new ConexionBD();
        public void Almacenar()
        {

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
           
            {
                try
                {
                    

                    string sql = "INSERT INTO PROCESOS (ID_PROCESOS, NOMBRE_PROCESO, DESCRIPCION, ID_USUARIO ) " +
                                 "VALUES (@ID_PROCESOS, @NOMBRE_PROCESO, @DESCRIPCION, @ID_USUARIO)";

                    using (SqlCommand command = new SqlCommand(sql, conexion))
                    {
                        command.Parameters.AddWithValue("@ID_PROCESOS", txtIdPro.Text);
                        command.Parameters.AddWithValue("@NOMBRE_PROCESO", txtNomb.Text);
                        command.Parameters.AddWithValue("@DESCRIPCION", txtdescr.Text);
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Almacenar();
        }

        // ✅ Función para generar el siguiente ID automáticamente
        private int ObtenerSiguienteIdUsuario()
        {
            int siguienteId = 1;

            using (SqlConnection conexion = new SqlConnection(conexiontionString))
            {
                conexion.Open();
                string consulta = "SELECT ISNULL(MAX(ID_PROCESOS), 0) + 1 FROM PROCESOS";
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

                    string consulta = "SELECT ISNULL(MAX(ID_PROCESOS), 0) + 1 FROM PROCESOS";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    object resultado = cmd.ExecuteScalar();
                    txtIdPro.Text = (resultado != null) ? resultado.ToString() : "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar ID: " + ex.Message);
                txtIdPro.Text = "1";
            }
        }
    }
}
