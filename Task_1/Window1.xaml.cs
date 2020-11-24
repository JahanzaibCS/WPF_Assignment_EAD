using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        
        ObservableCollection<ModelObj> list = new ObservableCollection<ModelObj>();
        public Window1()
        {
            InitializeComponent();
            
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            if (FirstName.Text.Length > 0 && LastName.Text.Length > 0 && Email.Text.Length > 0 )
            {
                if(FirstName.Text.Equals(LastName.Text))
                {
                    MessageBox.Show("FirstName and LastName should be different");
                }
                else
                {
                    if(Password.Text.Equals(ConfirmPassword.Text))
                    {
                        if (Password.Text.Length >= 5)
                        {
                            MessageBox.Show($"Data Added Succefully");
                            FirstName.Clear();
                            LastName.Clear();
                            Email.Clear();
                            Password.Clear();
                            ConfirmPassword.Clear();
                           
                        }
                        else
                        {
                            MessageBox.Show("Please Enter at least 5 values for Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password and ConfirmPassword are not same");

                    }

                }
               
                
            }
          else
            {
                MessageBox.Show("Please Enter All Values");
            }
            
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
