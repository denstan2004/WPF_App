using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApp.Enteties
{
    internal class OrderStatus
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }

        // Зв'язок зі замовленнями (один до багатьох)
        public virtual ICollection<Order> Orders { get; set; }
    }
}
