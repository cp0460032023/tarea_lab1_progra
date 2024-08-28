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
    public partial class Form1 : Form  // Define la clase Form1, que hereda de Form para crear una ventana de formulario.
    {
        public Form1()  // Constructor de la clase Form1.
        {
            InitializeComponent();  // Inicializa los componentes del formulario.
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e) 
            // Evento para guardar cambios en el BindingNavigator.
        {
            this.Validate();  // Valida los datos del formulario.
            this.customersBindingSource.EndEdit();  // Finaliza la edición de los datos en el BindingSource.
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);  // Actualiza todos los cambios en el DataSet.
        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)  // Otro evento para guardar cambios en el BindingNavigator.
        {
            this.Validate();  // Valida los datos del formulario.
            this.customersBindingSource.EndEdit();  // Finaliza la edición de los datos en el BindingSource.
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);  // Actualiza todos los cambios en el DataSet.
        }

        private void customersBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)  // Otro evento para guardar cambios en el BindingNavigator.
        {
            this.Validate();  // Valida los datos del formulario.
            this.customersBindingSource.EndEdit();  // Finaliza la edición de los datos en el BindingSource.
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);  // Actualiza todos los cambios en el DataSet.
        }

        private void Form1_Load(object sender, EventArgs e)  // Evento que se ejecuta al cargar el formulario.
        {
            // Carga datos en la tabla 'Customers' del DataSet 'northwindDataSet'.
            // Puede mover esta línea de código o eliminarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)  // Evento para manejar clics en celdas del DataGridView.
        {
            // Implementar la lógica cuando se haga clic en una celda del DataGridView, si es necesario.
        }
    }
}
