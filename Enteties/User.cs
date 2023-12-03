using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApp.Enteties
{
    class User
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
        public User(int id, string login, string password)
        {
            ID = id;
            Login = login;
            Password = password;
        }

        public override string? ToString()
        {
            return (ID.ToString()+" "+ Login+ " "+Password);
        }

        public User() { }

        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }
    }
}
