using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApp.Enteties
{
    internal class Order
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int StatusId { get; set; }

        // Зв'язок з користувачем (багато до одного)
        public virtual User User { get; set; }

        // Зв'язок зі статусом замовлення (багато до одного)
        public virtual OrderStatus Status { get; set; }
    }
}
