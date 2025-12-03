using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static INICIO.roles;





namespace INICIO
{// Instancia de la clase de conexión
    public partial class roles : Form
    {
        private string conexiontionString;
        private ConexionBD conexionDB = new ConexionBD(); 




        public roles()
        {
            InitializeComponent();
        }

        private void roles_Load(object sender, EventArgs e)
        {
            CargarRoles();


        }




        // Método que carga los roles disponibles desde la base de datos y los muestra en un ComboBox
        // Establece una conexión con la base de datos usando el patrón 'using' para garantizar su cierre automático
        // Define la consulta SQL para obtener el ID y nombre de todos los roles
        // Crea el comando SQL con la consulta y la conexión
        // Ejecuta la consulta y obtiene un lector de datos
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

                    cmbnombrerol.DataSource = dt;
                    cmbnombrerol.DisplayMember = "NOMBRE_ROL";
                    cmbnombrerol.ValueMember = "ID_ROL";
                    cmbnombrerol.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al cargar roles: " + ex.Message);
                }
            }
        }
        // Evento del botón guardar que inserta un nuevo rol en la base de datos
        // Obtiene y valida los datos ingresados en los campos del formulario
        // Valida que los campos obligatorios no estén vacíos
        // Refrescar roles en el formulario de usuarios
        private void btnguardar_Click(object sender, EventArgs e)
        {
            string id = txtidrol.Text.Trim();
            string nombre = cmbnombrerol.Text.Trim();
            string descripcion = txtdescrip.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {

                    string query = "INSERT INTO ROL (ID_ROL ,NOMBRE_ROL, DESCRIPCION) VALUES (@idrol, @Nombre, @Descripcion)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@idrol", id);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Rol guardado correctamente en SQL.");

                    
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f is usuarios)
                        {
                            ((usuarios)f).CargarRoles();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al guardar: " + ex.Message);
            }

            cmbnombrerol.Text = "";
            txtdescrip.Clear();
            txtdescrip.Focus();
        }



        // Evento del botón eliminar que borra un rol de la base de datos por su ID
        // Valida que se haya ingresado un ID de rol
        // Ejecuta la eliminación del rol en la tabla ROL
        // Verifica si se eliminó algún registro y muestra el resultado
        // Limpia todos los campos después de la operación
        private void btneliminar_Click(object sender, EventArgs e)
        {
            string id = txtidrol.Text;

            if (id == "")
            {
                MessageBox.Show("Ingresa el Id del rol a eliminar.");
                return;
            }

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {

                    string query = "DELETE FROM ROL WHERE ID_ROL = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);

                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                        MessageBox.Show("🗑️ Rol eliminado correctamente");
                    else
                        MessageBox.Show("No se encontró un rol con ese Id.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al eliminar: " + ex.Message);
            }


            txtidrol.Clear();
            cmbnombrerol.Text = "";
            txtdescrip.Clear();
            txtdescrip.Focus();
        }



        // Preguntar si está seguro de salir
        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?",
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
        // esto indica que abra con la app predeterminada

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = @"C:\Users\Belen\Downloads\MANUAL ROLES.pdf",
                UseShellExecute = true 
            };
            System.Diagnostics.Process.Start(psi);
        }
        // Ruta del PDF en la carpeta del ejecutable
        private void btnayuda_Click_1(object sender, EventArgs e)
        {
            
            string rutaPdf = Path.Combine(Application.StartupPath, "MANUAL ROLES.pdf");

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
