using Plugins.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTaskCartCalc.DataModel
{
    public class CartItem
    {
        public int Id { get; set; }

        private string _name;
        /// <summary>
        /// Name of cart item
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = Helper.CleanString(value); }
        }

        /// <summary>
        /// Descriprion for cart item
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Currency for this cart item
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Item prices
        /// </summary>
        public List<ItemPrice> ItemPrices { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        public CartItem(int id, string name)
        {
            if (id == 0)
            {
                throw new ArgumentNullException("CartItem: Id is mandatory field.");
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("CartItem: Name is mandatory field.");
            }

            Id = id;
            Name = name;
            ItemPrices = new List<ItemPrice>();
        }
    }
}
