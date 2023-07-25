using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VentadeBebidas.Services;

namespace VentadeBebidas.Vista_WPF
{
    /// <summary>
    /// Lógica de interacción para VentanaRegistro.xaml
    /// </summary>
    public partial class VentanaRegistro : Window
    {
        private object selectedClass; 
        private dynamic selectedService;
        public VentanaRegistro()
        {
            InitializeComponent();
        }
        private void ClassSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Obtener la clase seleccionada del ComboBox
            selectedClass = ((ComboBoxItem)ClassSelector.SelectedItem).Content;

            // Asignar la clase seleccionada
            switch (selectedClass)
            {
                case "Producto":
                    selectedService = new ProductoServices();
                    break;
                case "Vendedor":
                    selectedService = new VendedorServices();
                    break;
            }

            // Cargar los registros de la clase
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            // Obtener los registros de la clase
            var records = selectedService.GetRecords();

            // Asignar registros DataGrid
            DataGrid.ItemsSource = records;
        }

    }
}
