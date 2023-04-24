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
using System.Windows.Navigation;
using System.Windows.Shapes;
using PropertyList_Exam_2022;

namespace PropertyList_Exam_2022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RentalPropertyData db = new RentalPropertyData();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ReadFromDb();
        }

        private void ReadFromDb()
        {
            var query = from rentals in db.RentalProperties
                        select rentals;


            lbx_propertyListing.ItemsSource = query.ToList();
        }

        private void lbx_propertyListing_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProperty = lbx_propertyListing.SelectedItem as RentalProperty;

            tbk_propertyDescription.Text = selectedProperty.description;
        }

        private void btn_addProperty_Click(object sender, RoutedEventArgs e)
        {
            var addPropertyWindow = new AddProperty();

            addPropertyWindow.Owner = this;
            addPropertyWindow.ShowDialog();
            ReadFromDb();
        }
    }
}
