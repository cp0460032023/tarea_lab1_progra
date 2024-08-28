using System;                      // Importa las clases básicas del sistema.
using System.Collections.Generic;  // Importa clases para trabajar con colecciones genéricas.
using System.ComponentModel;       // Importa clases para implementar la funcionalidad de componentes.
using System.Data;                 // Importa clases para manejar datos y bases de datos.
using System.Drawing;              // Importa clases para manipular gráficos y diseño.
using System.Linq;                 // Importa clases para consultas a colecciones.
using System.Text;                 // Importa clases para manejar textos y codificaciones.
using System.Threading.Tasks;      // Importa clases para tareas asincrónicas.
using System.Windows.Forms;        // Importa clases para crear aplicaciones de Windows Forms.
using System.Data.SqlClient;       // Importa clases para interactuar con bases de datos SQL Server.
using DatosLayer;                  // Importa el espacio de nombres para la capa de datos personalizada.
using System.Net;                  // Importa clases para manejar protocolos de red.
using System.Reflection;           // Importa clases para manipulación de metadatos.

namespace ConexionEjemplo           // Define un espacio de nombres para organizar las clases.
{
    public partial class Form1 : Form  // Declara la clase Form1 que hereda de la clase Form.
    {
        CustomerRepository customerRepository = new CustomerRepository();  // Instancia un repositorio para manejar clientes.

        public Form1()                   // Constructor de la clase Form1.
        {
            InitializeComponent();       // Inicializa los componentes del formulario.
        }

        private void btnCargar_Click(object sender, EventArgs e)   // Evento que se dispara al hacer clic en el botón "Cargar".
        {
            var Customers = customerRepository.ObtenerTodos();     // Obtiene todos los clientes desde el repositorio.
            dataGrid.DataSource = Customers;                       // Asigna la lista de clientes al control dataGrid.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)  // Evento que se dispara cuando el texto en el TextBox cambia.
        {
            // (Código comentado que filtra los clientes por el nombre de la empresa)
        }

        private void Form1_Load(object sender, EventArgs e)  // Evento que se dispara cuando el formulario se carga.
        {
            // (Código comentado para inicializar configuraciones de la base de datos)
        }

        private void btnBuscar_Click(object sender, EventArgs e)   // Evento que se dispara al hacer clic en el botón "Buscar".
        {
            var cliente = customerRepository.ObtenerPorID(txtBuscar.Text);  // Busca un cliente por su ID.
            tboxCustomerID.Text = cliente.CustomerID;                 // Muestra el ID del cliente en el TextBox correspondiente.
            tboxCompanyName.Text = cliente.CompanyName;               // Muestra el nombre de la empresa en el TextBox correspondiente.
            tboxContacName.Text = cliente.ContactName;                // Muestra el nombre del contacto en el TextBox correspondiente.
            tboxContactTitle.Text = cliente.ContactTitle;             // Muestra el título del contacto en el TextBox correspondiente.
            tboxAddress.Text = cliente.Address;                       // Muestra la dirección en el TextBox correspondiente.
            tboxCity.Text = cliente.City;                             // Muestra la ciudad en el TextBox correspondiente.
        }

        private void label4_Click(object sender, EventArgs e)  // Evento que se dispara al hacer clic en el label4 (no hace nada).
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)  // Evento que se dispara al hacer clic en el botón "Insertar".
        {
            var resultado = 0;                                      // Inicializa la variable resultado.
            var nuevoCliente = ObtenerNuevoCliente();               // Crea un nuevo cliente basado en los datos ingresados.

            // (Código comentado que valida los campos y guarda el cliente en la base de datos)

            if (validarCampoNull(nuevoCliente) == false)            // Verifica si todos los campos del cliente están completos.
            {
                resultado = customerRepository.InsertarCliente(nuevoCliente);  // Inserta el nuevo cliente en la base de datos.
                MessageBox.Show("Guardado" + "Filas modificadas = " + resultado);  // Muestra un mensaje de éxito.
            }
            else
            {
                MessageBox.Show("Debe completar los campos por favor");  // Muestra un mensaje de error si hay campos vacíos.
            }
        }

        public Boolean validarCampoNull(Object objeto)  // Método para validar si algún campo de un objeto está vacío.
        {
            foreach (PropertyInfo property in objeto.GetType().GetProperties())
            {  // Recorre todas las propiedades del objeto.
                object value = property.GetValue(objeto, null);                    // Obtiene el valor de la propiedad.
                if ((string)value == "")
                {                                         // Verifica si el valor es una cadena vacía.
                    return true;                                                   // Retorna true si encuentra un campo vacío.
                }
            }
            return false;  // Retorna false si no encuentra campos vacíos.
        }

        private void label5_Click(object sender, EventArgs e)  // Evento que se dispara al hacer clic en el label5 (no hace nada).
        {

        }

        private void btModificar_Click(object sender, EventArgs e)  // Evento que se dispara al hacer clic en el botón "Modificar".
        {
            var actualizarCliente = ObtenerNuevoCliente();                      // Crea un objeto cliente con los datos ingresados.
            int actualizadas = customerRepository.ActualizarCliente(actualizarCliente);  // Actualiza los datos del cliente en la base de datos.
            MessageBox.Show($"Filas actualizadas = {actualizadas}");  // Muestra un mensaje con el número de filas actualizadas.
        }

        private Customers ObtenerNuevoCliente()  // Método para obtener un objeto cliente con los datos del formulario.
        {
            var nuevoCliente = new Customers  // Crea un nuevo objeto cliente y asigna los valores de los TextBox.
            {
                CustomerID = tboxCustomerID.Text,
                CompanyName = tboxCompanyName.Text,
                ContactName = tboxContacName.Text,
                ContactTitle = tboxContactTitle.Text,
                Address = tboxAddress.Text,
                City = tboxCity.Text
            };

            return nuevoCliente;  // Retorna el objeto cliente creado.
        }

        private void btnEliminar_Click(object sender, EventArgs e)  // Evento que se dispara al hacer clic en el botón "Eliminar".
        {
            int elimindas = customerRepository.EliminarCliente(tboxCustomerID.Text);  // Elimina el cliente de la base de datos.
            MessageBox.Show("Filas eliminadas = " + elimindas);  // Muestra un mensaje con el número de filas eliminadas.
        }
    }
}
