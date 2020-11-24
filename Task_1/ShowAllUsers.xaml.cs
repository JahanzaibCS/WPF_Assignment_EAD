using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Task_1
{
    /// <summary>
    /// Interaction logic for ShowAllUsers.xaml
    /// </summary>
    public partial class ShowAllUsers : Window 
    {
        List<ModelObj> displayList = new List<ModelObj>();
        public ShowAllUsers()
        {

            InitializeComponent();
            displayList.Add(new ModelObj { Fname = "Muhammad", LName = "Jahanzaib", Email = "BCSF17A554@pucit.edu.pk" }); 
            displayList.Add(new ModelObj { Fname = "Muhammad", LName = "Shahzaib", Email = "BCSF17A547@pucit.edu.pk" });
            displayList.Add(new ModelObj { Fname = "Adeel", LName = "Ahmad", Email = "BCSF17A542@pucit.edu.pk" });
            displayList.Add(new ModelObj { Fname = "Shafqat", LName = "Mehmood", Email = "BCSF17A512@pucit.edu.pk" });
            displayList.Add(new ModelObj { Fname = "Haseena", LName = "Wajid", Email = "BCSF17A564@pucit.edu.pk" });
            lstBox.ItemsSource = displayList;
            lstBox2.ItemsSource = displayList;
            lstBox3.ItemsSource = displayList;

        }

        private void Ecit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

