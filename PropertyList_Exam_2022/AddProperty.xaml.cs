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
            cbx_rentalType.ItemsSource = Enum.GetNames(typeof(RentalType));
        }

        private void btn_saveData_Click(object sender, RoutedEventArgs e)
        {
            
            var mainWindow = Owner as MainWindow;

            int rentalType = cbx_rentalType.SelectedIndex;
            string location = tbx_location.Text;
            string desciption = tbx_description.Text;
            decimal price = Convert.ToDecimal(tbx_price.Text);

            using (RentalPropertyData db = new RentalPropertyData())
            {
                RentalProperty rentalProperty = new RentalProperty()
                {
                    location = location,
                    price = price,
                    description = desciption,
                    RentalType = (RentalType)rentalType
                };

                db.RentalProperties.Add(rentalProperty);
                db.SaveChanges();
            }

            Close();

        }

        private void cbx_rentalType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbx_location.Text = cbx_rentalType.SelectedItem.ToString();
        }
    }
}
