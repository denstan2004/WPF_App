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

namespace MyTestApp
{
    /// <summary>
    /// Interaction logic for AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Button_Redirect_Register(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
        private void Button_Log_Click(object sender, RoutedEventArgs e)
        {

            string login = TextBoxLogin.Text.Trim();
            string password = TextBoxReg.Password.Trim();


            if (login.Length < 5)
            {
                MessageBox.Show("login can`t be less then 8 characters");
            }
            else if (password.Length < 5)
            {
                MessageBox.Show("password can`t be less then 8 characters");
            }

        }
    }
}
