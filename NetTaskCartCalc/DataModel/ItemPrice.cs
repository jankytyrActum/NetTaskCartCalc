using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTaskCartCalc.DataModel
{
    public class ItemPrice
    {
        /// <summary>
        /// Value of item price
        /// </summary>
        public double Price { get; set; }

        public int DiscountLow { get; set; }

        public int DiscountHigh { get; set; }

        public ItemPrice(double price)
        {
            Price = price;
            DiscountLow = 1;
            DiscountHigh = 1000;
        }

        public ItemPrice(double price, int discountLow, int discountHigh)
        {
            Price = price;
            DiscountLow = discountLow;
            DiscountHigh = discountHigh;
        }
    }
}
