using System;                     // Importa las clases básicas del sistema.
using System.Collections.Generic; // Importa clases para trabajar con colecciones genéricas.
using System.Linq;                // Importa clases para consultas a colecciones.
using System.Text;                // Importa clases para manejar textos y codificaciones.
using System.Threading.Tasks;     // Importa clases para tareas asincrónicas.

namespace DatosLayer              // Define el espacio de nombres para la capa de datos.
{
    public class Customers        // Define la clase Customers para representar un cliente.
    {
        public string CustomerID { get; set; }    // Propiedad para almacenar el ID del cliente.
        public string CompanyName { get; set; }   // Propiedad para almacenar el nombre de la empresa del cliente.
        public string ContactName { get; set; }   // Propiedad para almacenar el nombre del contacto del cliente.
        public string ContactTitle { get; set; }  // Propiedad para almacenar el título del contacto del cliente.
        public string Address { get; set; }       // Propiedad para almacenar la dirección del cliente.
        public string City { get; set; }           // Propiedad para almacenar la ciudad del cliente.
        public string Region { get; set; }         // Propiedad para almacenar la región del cliente.
        public string PostalCode { get; set; }     // Propiedad para almacenar el código postal del cliente.
        public string Country { get; set; }        // Propiedad para almacenar el país del cliente.
        public string Phone { get; set; }          // Propiedad para almacenar el teléfono del cliente.
        public string Fax { get; set; }            // Propiedad para almacenar el fax del cliente.
    }
}
