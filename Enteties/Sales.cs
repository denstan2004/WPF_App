using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApp.Enteties
{
    internal class Sales
    {
        public int ID { get; set; }
        public int ProductId { get; set; }
        public int QuantitySold { get; set; }
        public DateTime SaleDate { get; set; }

        // Зв'язок з товаром (один до багатьох)
        public virtual Product Product { get; set; }
    }
}
