using System;                     // Incluye las clases esenciales del sistema.
using System.Collections.Generic; // Incluye clases para trabajar con colecciones genéricas.
using System.Linq;                // Incluye clases para realizar consultas sobre colecciones.
using System.Text;                // Incluye clases para manipular texto y codificaciones.
using System.Threading.Tasks;     // Incluye clases para manejar tareas asincrónicas.
using System.Configuration;       // Incluye clases para gestionar configuraciones de la aplicación.
using System.Xml.Linq;            // Incluye clases para trabajar con XML y consultas LINQ to XML.
using System.Data.SqlClient;      // Incluye clases para manejar conexiones y comandos con SQL Server.
using System.Runtime.CompilerServices; // Incluye clases para operaciones a nivel de compilador y tiempo de ejecución.

namespace DatosLayer              // Declara un espacio de nombres para la capa de acceso a datos.
{
    public class DataBase         // Declara la clase DataBase para gestionar la configuración de la base de datos.
    {
        public static string ConnectionString
        {  // Propiedad estática para obtener la cadena de conexión de la base de datos.
            get
            {
                // Extrae la cadena de conexión desde el archivo de configuración de la aplicación.
                string CadenaConexion = ConfigurationManager
                    .ConnectionStrings["NWConnection"]
                    .ConnectionString;

                // Crea un objeto SqlConnectionStringBuilder utilizando la cadena de conexión extraída.
                SqlConnectionStringBuilder conexionBuilder =
                    new SqlConnectionStringBuilder(CadenaConexion);

                // Asigna el nombre de la aplicación al SqlConnectionStringBuilder, si está definido.
                conexionBuilder.ApplicationName =
                    ApplicationName ?? conexionBuilder.ApplicationName;

                // Configura el tiempo de espera para la conexión, si se ha definido un valor positivo.
                conexionBuilder.ConnectTimeout = (ConnectionTimeout > 0)
                    ? ConnectionTimeout : conexionBuilder.ConnectTimeout;

                // Devuelve la cadena de conexión completa generada.
                return conexionBuilder.ToString();
            }
        }

        public static int ConnectionTimeout { get; set; }
        // Propiedad estática para definir el tiempo de espera de la conexión.
        public static string ApplicationName { get; set; }
        // Propiedad estática para definir el nombre de la aplicación.

        public static SqlConnection GetSqlConnection()
        // Método estático que devuelve una conexión SQL.
        {
            // Instancia un objeto SqlConnection usando la cadena de conexión generada.
            SqlConnection conexion = new SqlConnection(ConnectionString);
            conexion.Open();  // Establece la conexión con la base de datos.
            return conexion;  // Devuelve la conexión abierta.
        }
    }
}
