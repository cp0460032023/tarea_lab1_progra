using System;                     // Importa las clases básicas del sistema.
using System.Collections.Generic; // Importa clases para trabajar con colecciones genéricas.
using System.Linq;                // Importa clases para consultas a colecciones.
using System.Threading.Tasks;     // Importa clases para tareas asincrónicas.
using System.Windows.Forms;       // Importa clases para crear interfaces de usuario de Windows Forms.

namespace DataSourceDemo          // Define el espacio de nombres para la demo del origen de datos.
{
    internal static class Program  // Define la clase Program como estática e interna.
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]  // Indica que la aplicación usa un solo hilo de apartamento (para compatibilidad con tecnologías COM).
        static void Main()  // Método principal, punto de entrada para la aplicación.
        {
            Application.EnableVisualStyles();  // Habilita los estilos visuales para los controles de Windows Forms.
            Application.SetCompatibleTextRenderingDefault(false);  // Configura el modo de renderizado de texto.
            Application.Run(new Form2());  // Inicia la aplicación y muestra el formulario 'Form2'.
        }
    }
}
