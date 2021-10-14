using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetTaskCartCalc.BussinessLogic;
using NetTaskCartCalc.DataModel;

namespace UnitTestProject
{
    [TestClass]
    public class CalculationTest
    {
        Database database = new Database();
        DatabaseService databaseService = null;
        CartItem vase = null;
        CartItem bigMug = null;
        CartItem napkinsPack = null;

       [TestInitialize()]
        public void Initialize()
        {
            databaseService = new DatabaseService(database);

            // Sample data

            vase = new CartItem(1, "Vase");
            vase.Currency = "€";
            vase.ItemPrices.Add(new ItemPrice(1.2));
            databaseService.AddCartItem(vase);

            bigMug = new CartItem(2, "Big mug");
            bigMug.Currency = "€";
            bigMug.ItemPrices.Add(new ItemPrice(1, 1, 2));
            bigMug.ItemPrices.Add(new ItemPrice(1.5 / 2, 2, 1000));
            databaseService.AddCartItem(bigMug);

            napkinsPack = new CartItem(3, "Napkins pack");
            napkinsPack.Currency = "€";
            napkinsPack.ItemPrices.Add(new ItemPrice(0.45, 1, 3));
            napkinsPack.ItemPrices.Add(new ItemPrice(0.9 / 3, 3, 1000));
            databaseService.AddCartItem(napkinsPack);

            Cart cart = new Cart();
            databaseService.AddCart(cart);
        }



        [TestMethod]
        public void TestCountTotal()
        {
            if (database.Carts.Count > 0)
            {
                double cartPrice = CartService.GetCartFinalPrice(database.Carts[0]);
                databaseService.AddItemToCart(database.Carts[0], 1);
                cartPrice = CartService.GetCartFinalPrice(database.Carts[0]);
                databaseService.AddItemToCart(database.Carts[0], 2);
                cartPrice = CartService.GetCartFinalPrice(database.Carts[0]);
                databaseService.AddItemToCart(database.Carts[0], 1);
                cartPrice = CartService.GetCartFinalPrice(database.Carts[0]);
                databaseService.AddItemToCart(database.Carts[0], 3);
                cartPrice = CartService.GetCartFinalPrice(database.Carts[0]);
                databaseService.AddItemToCart(database.Carts[0], 1);
                cartPrice = CartService.GetCartFinalPrice(database.Carts[0]);
                databaseService.AddItemToCart(database.Carts[0], 1);
                cartPrice = CartService.GetCartFinalPrice(database.Carts[0]);
                databaseService.AddItemToCart(database.Carts[0], 3);
                cartPrice = CartService.GetCartFinalPrice(database.Carts[0]);
                databaseService.AddItemToCart(database.Carts[0], 3);
                cartPrice = CartService.GetCartFinalPrice(database.Carts[0]);
                databaseService.AddItemToCart(database.Carts[0], 1);
                cartPrice = CartService.GetCartFinalPrice(database.Carts[0]);

                double check = 5 * 1.2 + 1 + 0.9;

                Assert.AreEqual(cartPrice, check);
            }
            else
            {
                Assert.Fail("No cart in Database");
            }
        }
    }
}
