using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApp.Enteties
{
    internal class AuditTrail
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public string Action { get; set; }
        public DateTime Timestamp { get; set; }
        public string Details { get; set; }

        // Зв'язок з користувачем (багато до одного)
        public virtual User User { get; set; }
    }
}
