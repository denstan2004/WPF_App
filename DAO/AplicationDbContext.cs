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
       
        DbSet<AuditTrail> auditTrails;
        DbSet<Category> categories;
        DbSet<Order> orders;
        DbSet<OrderStatus> ordersStatus;
        DbSet<PaymentDetails> paymentDetails;
        DbSet<Product> products;
        DbSet<Sales> sales;
        DbSet<ShoppingCart> shoppingCarts;
        DbSet<User> users;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SID=xe)));User Id=sys;Password=123456;DBA Privilege=SYSDBA;");
        }

    }
}
