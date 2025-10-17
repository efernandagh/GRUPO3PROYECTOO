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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace INICIO
{
    public partial class proveedores : Form
    {

        private ConexionBD conexionDB = new ConexionBD();
        private string conexiontionString;
        public proveedores()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void proveedores_Load(object sender, EventArgs e)
        {
            txtidproveedor.Enabled = false;
            GenerarNuevoId();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();



        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string query = @"INSERT INTO PROVEEDORES 
                             (ID_PROVEEDOR, NOMBRE_PROVEEDOR, TELEFONO, CORREO, DIRECCION)
                             VALUES (@id, @nombre, @telefono, @correo, @direccion)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", txtidproveedor.Text);
                        cmd.Parameters.AddWithValue("@nombre", textBox1.Text);
                        cmd.Parameters.AddWithValue("@telefono", textBox2.Text);
                        cmd.Parameters.AddWithValue("@correo", textBox3.Text);
                        cmd.Parameters.AddWithValue("@direccion", textBox4.Text);

                        int filas = cmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("✅ Proveedor guardado correctamente.",
                                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("⚠️ No se guardó el proveedor.",
                                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("❌ Error de base de datos: " + ex.Message,
                                "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error inesperado: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Función para generar el siguiente ID automáticamente
        private int ObtenerSiguienteIdUsuario()
        {
            int siguienteId = 1;

            using (SqlConnection conexion = new SqlConnection(conexiontionString))
            {
                conexion.Open();
                string consulta = "SELECT ISNULL(MAX(ID_PROVEEDOR), 0) + 1 FROM PROVEEDORES";
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

                    string consulta = "SELECT ISNULL(MAX(ID_PROVEEDOR), 0) + 1 FROM PROVEEDORES";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    object resultado = cmd.ExecuteScalar();
                    txtidproveedor.Text = (resultado != null) ? resultado.ToString() : "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar ID: " + ex.Message);
                txtidproveedor.Text = "1";
            }
        }
    }
}
