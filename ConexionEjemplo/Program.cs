using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionEjemplo
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();       // Habilita estilos visuales para la aplicación, mejorando la apariencia de los controles.
            Application.SetCompatibleTextRenderingDefault(false);   // Configura la compatibilidad del renderizado de texto a su valor predeterminado.
            Application.Run(new Form1());        // Inicia la ejecución de la aplicación y muestra el formulario principal (Form1).
        }
    }
}
