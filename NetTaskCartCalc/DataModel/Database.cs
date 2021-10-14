using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTaskCartCalc.DataModel
{
    public class Database
    {
        public List<CartItem> CartItems {get;set;}
        public List<Cart> Carts { get; set; }

        public Database()
        {
            CartItems = new List<CartItem>();
            Carts = new List<Cart>();
        }
    }
}
