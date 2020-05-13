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

namespace HannahByrne_S00189764
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var phones = from p in db.Phones
                         select p.Name;

            lbxPhoneList.ItemsSource = phones.ToList();

            //lbxPhoneList.SelectedItem = 0;
        }

        private void LbxPhoneList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone selected = lbxPhoneList.SelectedItem as Phone;

            //tblkPhonePrice.Text = selected.Price.ToString();


            //tblkPhonePrice.Text = phonePrice.ToString();

            // Couldn't get the Price to display, had some other text displaying
            var phonePrice = from p in db.Phones
                             select p.Price;

                tblkPhonePrice.Text = phonePrice.ToString();

            var phoneImage = from p in db.Phones
                             select p.Phone_Image;
                imgPhone.Source = new BitmapImage(new Uri($"{phoneImage}", UriKind.Relative));
            
        }
    }
}
