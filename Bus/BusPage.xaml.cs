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

namespace Bus
{
    /// <summary>
    /// Логика взаимодействия для BusPage.xaml
    /// </summary>
    public partial class BusPage : Page
    {
        public BusPage()
        {
            InitializeComponent();
            DataBase dt = new DataBase();
            BusGrid.ItemsSource = dt.getBusTable();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataBase dt = new DataBase();
            dt.insertNewBus(modelText.Text, Convert.ToDateTime(dateText.SelectedDate));
            BusGrid.ItemsSource = dt.getBusTable();
        }

        private void BusGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var ec = BusGrid.SelectedIndex + 1;
            DataBase dt = new DataBase();

            if (ec != 0) {
                BusGrid.ItemsSource = dt.getSelectedValue("Table_1", ec);
            }
            
        }

        private void BusGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
           
        }
    }
}
