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

namespace PropertyList_Exam_2022
{
    /// <summary>
    /// Interaction logic for AddProperty.xaml
    /// </summary>
    public partial class AddProperty : Window
    {
        public AddProperty()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RentalProperty rentalProperties = new RentalProperty();
            var test = Enum.GetValues(typeof(RentalType));
            cbx_rentalType.ItemsSource = Enum.GetValues(typeof(RentalType));
        }

        private void btn_saveData_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = Owner as MainWindow;

            



        }

        private void cbx_rentalType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbx_location.Text = cbx_rentalType.SelectedItem.ToString();
        }
    }
}
