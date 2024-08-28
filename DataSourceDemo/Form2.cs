using System;                     // Importa las clases básicas del sistema.
using System.Collections.Generic; // Importa clases para trabajar con colecciones genéricas.
using System.ComponentModel;      // Importa clases para componentes de Windows Forms y controles.
using System.Data;                // Importa clases para manejar datos y bases de datos.
using System.Drawing;            // Importa clases para trabajar con gráficos y dibujos.
using System.Linq;                // Importa clases para consultas a colecciones.
using System.Text;                // Importa clases para manejar textos y codificaciones.
using System.Threading.Tasks;     // Importa clases para tareas asincrónicas.
using System.Windows.Forms;       // Importa clases para crear interfaces de usuario de Windows Forms.

namespace DataSourceDemo          // Define el espacio de nombres para la demo del origen de datos.
{
    public partial class Form2 : Form  // Define la clase Form2, que hereda de Form para crear una ventana de formulario.
    {
        public Form2()  // Constructor de la clase Form2.
        {
            InitializeComponent();  // Inicializa los componentes del formulario.
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)  // Evento para guardar cambios en el BindingNavigator.
        {
            this.Validate();  // Valida los datos del formulario.
            this.customersBindingSource.EndEdit();  // Finaliza la edición de los datos en el BindingSource.
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);  // Actualiza todos los cambios en el DataSet.
        }

        private void Form2_Load(object sender, EventArgs e)  // Evento que se ejecuta al cargar el formulario.
        {
            // Carga datos en la tabla 'Customers' del DataSet 'northwindDataSet'.
            // Puede mover esta línea de código o eliminarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
        }

        private void cajaTextoID_Click(object sender, EventArgs e)  // Evento para manejar clics en el control 'cajaTextoID'.
        {
            // Implementar la lógica cuando se haga clic en 'cajaTextoID', si es necesario.
        }

        private void cajaTextoID_KeyPress(object sender, KeyPressEventArgs e)  // Evento para manejar la presión de teclas en el control 'cajaTextoID'.
        {
            // Verifica si la tecla presionada es Enter (código de carácter 13).
            if (e.KeyChar == (char)13)
            {
                // Busca el índice del cliente en el BindingSource que coincide con el valor de 'cajaTextoID'.
                var index = customersBindingSource.Find("customerID", cajaTextoID.Text);

                // Si el índice es válido (mayor que -1), establece la posición en el BindingSource.
                if (index > -1)
                {
                    customersBindingSource.Position = index;
                    return;  // Sale del método si se encuentra el elemento.
                }
                else
                {
                    // Muestra un mensaje si el elemento no se encuentra.
                    MessageBox.Show("Elemento no encontrado");
                }
            }
        }
    }
}
