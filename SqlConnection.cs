using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INICIO;
using Microsoft.Data.SqlClient;

namespace ConexionnSQL
{
    public static class DatabaseConnection
    {
        // Cadena de conexión como constante (puedes moverla a un archivo de configuración más adelante)
        private static readonly string connectionString = "Server=ALEJANDROC\\SQLEXPRESS;Database=MECANICA_INDUSTRIAL;Trusted_Connection=True;";

        /// Devuelve una conexión abierta a la base de datos Sakila.

        /// <returns>Una instancia de SqlConnection abierta</returns>
        /// <exception cref="Exception">Lanza una excepción si no se puede conectar</exception>
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                // Cierra la conexión si está abierta antes de lanzar la excepción
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
                throw new Exception("Error al conectar a la base de datos: " + ex.Message);
            }
        }
    }
}