using NetTaskCartCalc.BussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTaskCartCalc.DataModel
{
    public class Cart
    {
        /// <summary>
        /// List of items included in cart
        /// </summary>
      public  List<CartItem> CartItems { get; set; }

        /// <summary>
        /// Final price of all items in cart
        /// </summary>
        public double FinalPrice
        {
            get
            {
                return CartService.GetCartFinalPrice(this);
            }
        }

        public Cart()
        {
            CartItems = new List<CartItem>();
        }
    }
}
