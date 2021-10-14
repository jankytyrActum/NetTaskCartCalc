using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetTaskCartCalc.DataModel;

namespace NetTaskCartCalc.BussinessLogic
{
    public class DatabaseService
    {
        internal Database database;

        public DatabaseService(Database database)
        {
            this.database = database;
        }

        public void AddCart(Cart cart)
        {
            database.Carts.Add(cart);
        }

        public void AddCartItem(CartItem cartItem)
        {
            database.CartItems.Add(cartItem);
        }

        public void AddItemToCart(Cart cart, int id)
        {
            foreach (CartItem cartItem in database.CartItems)
            {
                if (id == cartItem.Id)
                {
                    cart.CartItems.Add(cartItem);
                    break;
                }
            }
        }
    }
}
