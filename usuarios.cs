
using Microsoft.Data.SqlClient; // Asegúrate de tener la referencia a Microsoft.Data.SqlClient
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace INICIO
{


    public partial class usuarios : Form
    {
       
        private string conexiontionString;
        private ConexionBD conexionDB = new ConexionBD(); // Instancia de la clase de conexión

        public usuarios()
        {
            InitializeComponent();
        }


        // 🔹 Método para cargar roles en el ComboBox
        public void CargarRoles()
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    
                    string query = "SELECT ID_ROL, NOMBRE_ROL FROM ROL";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    cmbrol.DataSource = dt;
                    cmbrol.DisplayMember = "NOMBRE_ROL";
                    cmbrol.ValueMember = "ID_ROL";
                    cmbrol.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al cargar roles: " + ex.Message);
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // validaciones básicas
            if (string.IsNullOrWhiteSpace(txtnombreusuario.Text) ||
                string.IsNullOrWhiteSpace(txtapellidousuarios.Text) ||
                string.IsNullOrWhiteSpace(txtcorreousuario.Text) ||
                string.IsNullOrWhiteSpace(txtclaveusuario.Text) ||
                cmbrol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    

                    // Si por alguna razón el ID está vacío, lo regeneramos
                    if (string.IsNullOrWhiteSpace(txtidusuario.Text))
                        GenerarNuevoId();

                    string query = @"INSERT INTO USUARIOS 
                                     (ID_USUARIO, NOMBRE, APELLIDO, CORREO, CLAVE, ID_ROL, FECHA_REGISTRO)
                                     VALUES (@ID, @NOMBRE, @APELLIDO, @CORREO, @CLAVE, @ROL, @FECHA)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt64(txtidusuario.Text));
                    cmd.Parameters.AddWithValue("@NOMBRE", txtnombreusuario.Text);
                    cmd.Parameters.AddWithValue("@APELLIDO", txtapellidousuarios.Text);
                    cmd.Parameters.AddWithValue("@CORREO", txtcorreousuario.Text);
                    cmd.Parameters.AddWithValue("@CLAVE", txtclaveusuario.Text);
                    cmd.Parameters.AddWithValue("@ROL", cmbrol.SelectedValue);
                    cmd.Parameters.AddWithValue("@FECHA", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Usuario guardado correctamente.");

                    // limpiar y generar ID nuevo
                    LimpiarCampos();
                    GenerarNuevoId();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al guardar: " + ex.Message);
            }
        }


        private void btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas eliminar los datos ingresados?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("🗑️ Datos eliminados correctamente.",
                    "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimpiarCampos();
        }

       



        // MÉTODO PARA LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            txtnombreusuario.Clear();
            txtapellidousuarios.Clear();
            txtcorreousuario.Clear();
            txtclaveusuario.Clear();
            cmbrol.Text = "";
            dtpfecha.Value = DateTime.Now;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MessageBox.Show("Operación cancelada.");
        }

        private void txtnombreusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            txtidusuario.Enabled = false;
            CargarRoles();
            dtpfecha.Value = DateTime.Now;
            txtidusuario.Enabled = false; // No permitir editar el ID
            GenerarNuevoId(); // 🔹 Llamar a función que genera el ID automáticamente
        }
        // ✅ Función para generar el siguiente ID automáticamente
        private int ObtenerSiguienteIdUsuario()
        {
            int siguienteId = 1;

            using (SqlConnection conexion = new SqlConnection(conexiontionString)) 
            {
                conexion.Open();
                string consulta = "SELECT ISNULL(MAX(ID_USUARIO), 0) + 1 FROM USUARIOS";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                siguienteId = Convert.ToInt32(comando.ExecuteScalar());
            }

            return siguienteId;
        }
        // <<-- Asegúrate de que este método exista y tenga este nombre EXACTO
        private void GenerarNuevoId()
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    
                    string consulta = "SELECT ISNULL(MAX(ID_USUARIO), 0) + 1 FROM USUARIOS";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    object resultado = cmd.ExecuteScalar();
                    txtidusuario.Text = (resultado != null) ? resultado.ToString() : "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar ID: " + ex.Message);
                txtidusuario.Text = "1";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
