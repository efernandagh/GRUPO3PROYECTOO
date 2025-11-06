
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INICIO
{
    internal class ConexionBD
    {
        private static string cadenaConexion;
        private static readonly string rutaConfig = "configuracion.txt";
        private static readonly string nombreBD = "MECANICA_INDUSTRIAL";

        static ConexionBD()
        {
            // Si el archivo existe, validamos que sea correcto
            if (File.Exists(rutaConfig))
            {
                string contenido = File.ReadAllText(rutaConfig).Trim();

                if (contenido.StartsWith("Server=", StringComparison.OrdinalIgnoreCase))
                {
                    cadenaConexion = contenido;
                }
                else
                {
                    // Archivo viejo o incorrecto -> reconstruir
                    string servidor = DetectarServidor();
                    cadenaConexion = $"Server={servidor};Database={nombreBD};Integrated Security=True;TrustServerCertificate=True;";
                    File.WriteAllText(rutaConfig, cadenaConexion);
                }
            }
            else
            {
                // No existe archivo -> crear con servidor detectado
                string servidor = DetectarServidor();
                cadenaConexion = $"Server={servidor};Database={nombreBD};Integrated Security=True;TrustServerCertificate=True;";
                File.WriteAllText(rutaConfig, cadenaConexion);
            }
        }

        public static SqlConnection ObtenerConexion()
        {
            try
            {
                SqlConnection conn = new SqlConnection(cadenaConexion);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al conectar con la base de datos:\n{ex.Message}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private static string DetectarServidor()
        {
            string[] posiblesServidores =
            {
                Environment.MachineName + "\\SQLEXPRESS",
                Environment.MachineName + "\\ENIAGOMEZ",
                Environment.MachineName,
                "localhost\\SQLEXPRESS",
                "localhost",
                "(localdb)\\MSSQLLocalDB"
            };

            foreach (string servidor in posiblesServidores)
            {
                try
                {
                    string prueba = $"Server={servidor};Integrated Security=True;TrustServerCertificate=True;";
                    using (SqlConnection conn = new SqlConnection(prueba))
                    {
                        conn.Open();
                        return servidor;
                    }
                }
                catch
                {
                    continue;
                }
            }

            MessageBox.Show("No se detectó ninguna instancia de SQL Server. Verifique que esté instalado e iniciado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
            return null;
        }
    }
}

