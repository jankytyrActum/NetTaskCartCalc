using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetTaskCartCalc.DataModel;

namespace NetTaskCartCalc.BussinessLogic
{
    public static class CartService
    {
        /// <summary>
        /// Get final price of items in cart
        /// </summary>
        /// <param name="cart"></param>
        /// <returns></returns>
        public static double GetCartFinalPrice(Cart cart)
        {
            double result = 0;

            foreach (CartItem cartItem in cart.CartItems)
            {
                int count = 0;

                /// Ps.. slo by to udelat i tak, ze count uz bude rovnou na cartItem, ale takto muzeme zohlednit napriklad ruzne barvene varianty na jednom produktu
                foreach (CartItem cartItemCount in cart.CartItems)
                {
                    if (cartItem.Id == cartItemCount.Id) { count++; }
                }

                foreach (ItemPrice itemPrice in cartItem.ItemPrices)
                {
                    if (itemPrice.DiscountLow <= count && itemPrice.DiscountHigh > count) { result += itemPrice.Price; }
                }
            }

            return result;
        }
    }
}
