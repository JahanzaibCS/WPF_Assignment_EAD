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

namespace Task_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ShowAllUsers s = new ShowAllUsers();
            s.Show();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
