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

        // Crear respaldo
        // Evento del botón que crea un respaldo (backup) de la base de datos
        // Define la ruta del archivo de respaldo en el escritorio del usuario
        // Ejecuta el comando BACKUP DATABASE para crear el archivo .bak
        // Muestra mensaje de éxito con la ubicación del respaldo o error si falla
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
        // Evento del botón que restaura la base de datos desde un archivo de respaldo
        // Abre un diálogo para que el usuario seleccione el archivo .bak
        // Se conecta a la base de datos master para ejecutar la restauración
        // Pone la base de datos en modo usuario único, restaura desde el archivo y vuelve a modo multiusuario
        // Muestra mensaje de éxito o error según el resultado de la operación
        // Se usa la base "master" para ejecutar el RESTORE
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
        // Ruta donde se guardará el respaldo
        // Verificar si la carpeta existe, si no, crearla
        //  Crear respaldo de la base de datos
        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                
                string carpetaRespaldo = @"C:\RespaldoSQL";
                string backupPath = Path.Combine(carpetaRespaldo, "MECANICA_INDUSTRIAL.bak");

                
                if (!Directory.Exists(carpetaRespaldo))
                {
                    Directory.CreateDirectory(carpetaRespaldo);
                }

                /
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
        // Preguntar si realmente quiere salir
        // Si el usuario presiona "Sí", cerrar el formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {

            
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir del sistema de facturas?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // Ruta del PDF en la carpeta del ejecutable
        private void btnayuda_Click(object sender, EventArgs e)
        {
            
            string rutaPdf = Path.Combine(Application.StartupPath, "MANUAL RESPALDO Y RESTAURACION.pdf");

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}



