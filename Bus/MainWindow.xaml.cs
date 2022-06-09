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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            getRouter();
        }

        private void getRouter() 
        {
            DataBase con = new DataBase();
            //BusGrid.ItemsSource = con.getBus();
        }

        private void BusGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void BusGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var arr = e;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new BusPage());
        }
    }
}
