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

namespace INICIO
{
    public partial class RespaldoYrestaurar : Form
    {
        private ConexionBD conexionDB = new ConexionBD();
        public RespaldoYrestaurar()
        {
            InitializeComponent();
        }

        private void RespaldoYrestaurar_Load(object sender, EventArgs e)
        {


        }

        // 🔹 Crear respaldo
        private void btnCrearBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string backupPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    "MECANICA_INDUSTRIAL.bak"
                );

                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = $"BACKUP DATABASE MECANICA_INDUSTRIAL TO DISK = '{backupPath}'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show($"✅ Respaldo creado correctamente en:\n{backupPath}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al crear el respaldo:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnrestau_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Archivos de respaldo (*.bak)|*.bak";
                open.Title = "Selecciona un archivo de respaldo";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    string backupFile = open.FileName;

                    // ⚠ Se usa la base "master" para ejecutar el RESTORE
                    string masterConnection = "Server=DESKTOP-8QJ2O4S\\ENIAGOMEZ;Database=master;Integrated Security=True;TrustServerCertificate=True;";

                    using (SqlConnection con = new SqlConnection(masterConnection))
                    {
                        con.Open();

                        string restoreQuery = @"
                            ALTER DATABASE MECANICA_INDUSTRIAL SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                            RESTORE DATABASE MECANICA_INDUSTRIAL FROM DISK = @backupFile WITH REPLACE;
                            ALTER DATABASE MECANICA_INDUSTRIAL SET MULTI_USER;
                        ";

                        SqlCommand cmd = new SqlCommand(restoreQuery, con);
                        cmd.Parameters.AddWithValue("@backupFile", backupFile);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("✅ Base de datos restaurada correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al restaurar el respaldo:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                // 📂 Ruta donde se guardará el respaldo
                string carpetaRespaldo = @"C:\RespaldoSQL";
                string backupPath = Path.Combine(carpetaRespaldo, "MECANICA_INDUSTRIAL.bak");

                // 🔹 Verificar si la carpeta existe, si no, crearla
                if (!Directory.Exists(carpetaRespaldo))
                {
                    Directory.CreateDirectory(carpetaRespaldo);
                }

                // 🔹 Crear respaldo de la base de datos
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = $"BACKUP DATABASE MECANICA_INDUSTRIAL TO DISK = '{backupPath}' WITH FORMAT, INIT;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show($"✅ Respaldo creado correctamente en:\n{backupPath}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al crear el respaldo:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
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
    }
}



