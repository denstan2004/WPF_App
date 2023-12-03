using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApp.Enteties
{
    internal class PaymentDetails
    {

        public int ID { get; set; }
        public int OrderId { get; set; }
        public string PaymentMethod { get; set; }
        public decimal AmountPaid { get; set; }

        // Зв'язок з замовленням (один до одного або багато)
        public virtual Order Order { get; set; }
    }
}
