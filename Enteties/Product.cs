using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApp.Enteties
{
    internal class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityAvailable { get; set; }
        public string ImageUrl { get; set; } 

        public int CategoryId { get; set; }
    }
}
