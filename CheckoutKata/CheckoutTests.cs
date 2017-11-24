using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CheckoutKata
{
    [TestClass]
    public class CheckoutTests
    {
        [TestMethod]
        public void ScanAItemShouldReturn50()
        {
            var chk = new Checkout();
            chk.Scan("A");
            Assert.AreEqual(50, chk.GetTotal());
        }

        [TestMethod]
        public void ScanBItemShouldReturn30()
        {
            var chk = new Checkout();
            chk.Scan("B");
            Assert.AreEqual(30, chk.GetTotal());
        }

        [TestMethod]
        public void ScanCItemShouldReturn20()
        {
            var chk = new Checkout();
            chk.Scan("C");
            Assert.AreEqual(20, chk.GetTotal());
        }

        [TestMethod]
        public void ScanDItemShouldReturn15()
        {
            var chk = new Checkout();
            chk.Scan("D");
            Assert.AreEqual(15, chk.GetTotal());
        }
    }

    public class Checkout
    {
        private int _total;
        public void Scan(string sku)
        {
            _total = ProductCollInit.products.Find(m => m.Name == sku).Price;           
        }

        public int GetTotal()
        {
            return _total;
        }
    }

    interface ICheckout
    {
        void Scan(string sku);
        int GetTotal();
    }

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public static class ProductCollInit
    {
        public static List<Product> products = new List<Product>
        {
            new Product
            {
                Name = "A",
                Price = 50
            },
            new Product
            {
                Name = "B",
                Price = 30
            },
            new Product
            {
                Name = "C",
                Price = 20
            },
            new Product
            {
                Name = "D",
                Price = 15
            }
        };
   }

}
