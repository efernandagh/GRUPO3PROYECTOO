
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace INICIO
{
    internal class ConexionBD
    {
        // 🔹 Cadena de conexión centralizada
        private static readonly string cadenaConexion =
            "Server=DESKTOP-8QJ2O4S\\ENIAGOMEZ;Database=MECANICA_INDUSTRIAL;Integrated Security=True;TrustServerCertificate=True;";

        // 🔹 Método para obtener una conexión abierta
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            conn.Open();
            return conn;
        }
    }
}

