using NetTaskCartCalc.BussinessLogic;
using NetTaskCartCalc.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTaskCartCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            DatabaseService databaseService = new DatabaseService(database);

            CartItem vase = new CartItem(1, "Vase");
            vase.Currency = "€";
            vase.ItemPrices.Add(new ItemPrice(1.2));
            databaseService.AddCartItem(vase);

            CartItem bigMug = new CartItem(2, "Big mug");
            bigMug.Currency = "€";
            bigMug.ItemPrices.Add(new ItemPrice(1, 1, 2));
            bigMug.ItemPrices.Add(new ItemPrice(1.5 / 2, 2, 1000));
            databaseService.AddCartItem(bigMug);

            CartItem napkinsPack = new CartItem(3, "Napkins pack");
            napkinsPack.Currency = "€";
            napkinsPack.ItemPrices.Add(new ItemPrice(0.45, 1, 3));
            napkinsPack.ItemPrices.Add(new ItemPrice(0.9 / 3, 3, 1000));
            databaseService.AddCartItem(napkinsPack);

            Cart cart = new Cart();
            databaseService.AddCart(cart);

            double cartPrice = CartService.GetCartFinalPrice(cart);
            databaseService.AddItemToCart(cart, 1);
            cartPrice = CartService.GetCartFinalPrice(cart);
            databaseService.AddItemToCart(cart, 2);
            cartPrice = CartService.GetCartFinalPrice(cart);
            databaseService.AddItemToCart(cart, 1);
            cartPrice = CartService.GetCartFinalPrice(cart);
            databaseService.AddItemToCart(cart, 3);
            cartPrice = CartService.GetCartFinalPrice(cart);
            databaseService.AddItemToCart(cart, 1);
            cartPrice = CartService.GetCartFinalPrice(cart);
            databaseService.AddItemToCart(cart, 1);
            cartPrice = CartService.GetCartFinalPrice(cart);
            databaseService.AddItemToCart(cart, 3);
            cartPrice = CartService.GetCartFinalPrice(cart);
            databaseService.AddItemToCart(cart, 3);
            cartPrice = CartService.GetCartFinalPrice(cart);
            databaseService.AddItemToCart(cart, 1);
            cartPrice = CartService.GetCartFinalPrice(cart);

            double check = 5 * 1.2 + 1 + 0.9;
            if (check == cartPrice)
            {
                Console.Write("OK");
            }
            else
            {
                Console.Write("NOK");
            }
        }
    }
}
