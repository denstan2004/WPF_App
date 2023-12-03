using Microsoft.EntityFrameworkCore;
using MyTestApp.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace WpfApp1.DAO
{
    internal class AplicationDbContext: DbContext
    {
       
       public DbSet<AuditTrail> auditTrails { get; set; }
        public DbSet<Category> categories{ get; set; }
        public DbSet<Order> orders{ get; set; }
        public DbSet<OrderStatus> ordersStatus{ get; set; }
        public DbSet<PaymentDetails> paymentDetails{ get; set; }
        public DbSet<Product> products{ get; set; }
        public DbSet<Sales> sales{ get; set; }
        public DbSet<ShoppingCart> shoppingCarts{ get; set; }
        public DbSet<User> users{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          optionsBuilder.UseOracle("Data Source=localhost:1521/xe;User Id=sys;Password=123456;DBA Privilege=SYSDBA;");
        }

    }
}
