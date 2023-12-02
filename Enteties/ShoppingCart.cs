using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApp.Enteties
{
    internal class ShoppingCart
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        // Зв'язок з користувачем (багато до одного)
        public virtual User User { get; set; }

        // Зв'язок з товаром (багато до одного)
        public virtual Product Product { get; set; }
    }
}
