﻿using MyTestApp.Enteties;
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
using WpfApp1;
using WpfApp1.DAO;

namespace MyTestApp
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
        AplicationDbContext aplication =new AplicationDbContext();
        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {

            string login = TextBoxLogin.Text.Trim();
            string password = TextBoxReg.Password.Trim();
            string password2 = TextBoxReg2.Password.Trim();

            if (login.Length < 5)
            {
                MessageBox.Show("login can`t be less then 8 characters");
            }
            else if (password.Length < 5)
            {
                MessageBox.Show("password can`t be less then 8 characters");
            }
            else if (password != password2)
            {
                MessageBox.Show("password mismatch");
            }
            else
            {
                User user = aplication.users.SingleOrDefault(e => login == e.Login);
                if(user != null)
                {
                    MessageBox.Show("user already exists");
                }
                else
                {
                    User user1 = new (login, password);
                    aplication.Add(user1);
                }
             
            }


        }

        private void Button_Redirect_login(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Hide();
        }

        private void Catalog_Redirect(object sender, RoutedEventArgs e)
        {
            CatalogWindowNoAuth catalogWindowNoAuth = new CatalogWindowNoAuth();
            catalogWindowNoAuth.Show();
            Hide() ;
        }
    }
}
