using MyTestApp;
using MyTestApp.Enteties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static System.Net.WebRequestMethods;

namespace WpfApp1
{
    public partial class CatalogWindowNoAuth : Window
    {
        private ObservableCollection<Product> Products { get; set; }
       

        public CatalogWindowNoAuth()
        {
            InitializeComponent();
            DataContext = this;

            // Приклад створення списку продуктів (додайте вашу логіку отримання даних)
            Products = new ObservableCollection<Product>
            {
                new Product { ProductName = "Product 1", Price = 10.99m, ImageUrl ="https://assets.stickpng.com/images/61d183263a856e0004c6334a.png" , QuantityAvailable=7},
                  new Product { ProductName = "Product 2", Price = 15.49m, ImageUrl = "https://assets.stickpng.com/images/61d183263a856e0004c6334a.png" ,QuantityAvailable=8},
                     new Product { ProductName = "Product 2", Price = 15.49m, ImageUrl = "https://assets.stickpng.com/images/61d183263a856e0004c6334a.png" ,QuantityAvailable=8},
                        new Product { ProductName = "Product 2", Price = 15.49m, ImageUrl = "https://assets.stickpng.com/images/61d183263a856e0004c6334a.png" ,QuantityAvailable=8},
                           new Product { ProductName = "Product 2", Price = 15.49m, ImageUrl = "https://assets.stickpng.com/images/61d183263a856e0004c6334a.png" ,QuantityAvailable=8},
                             new Product { ProductName = "Product 2", Price = 15.49m, ImageUrl = "https://assets.stickpng.com/images/61d183263a856e0004c6334a.png" ,QuantityAvailable=8},
                               new Product { ProductName = "Product 2", Price = 15.49m, ImageUrl = "https://assets.stickpng.com/images/61d183263a856e0004c6334a.png" ,QuantityAvailable=8},
                                 new Product { ProductName = "Product 2", Price = 15.49m, ImageUrl = "https://assets.stickpng.com/images/61d183263a856e0004c6334a.png" ,QuantityAvailable=8},


            };
        
            list.ItemsSource = Products;
            
        }

        private void Button_Redirect_login(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Hide();
        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hui");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main= new MainWindow();
            main.Show();
            Hide();
        }
    }
}