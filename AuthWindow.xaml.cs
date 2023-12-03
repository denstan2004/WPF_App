using MyTestApp.Enteties;
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
using WpfApp1.DAO;
using static System.Net.Mime.MediaTypeNames;

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
        AplicationDbContext aplication=new AplicationDbContext();

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


            User user = aplication.users.SingleOrDefault(e => login == e.Login);
            if (user != null)
            {
                if(user.Password==password)
                {
                    
                }
                else
                {
                    MessageBox.Show("inccorect password");
                }
            }
            else
            {
                MessageBox.Show("no such user");
            }

        }
    }
}
