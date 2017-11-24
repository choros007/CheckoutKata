using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

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

        [TestMethod]
        public void ScanAItemAndBShouldReturn80()
        {
            var chk = new Checkout();
            chk.Scan("A");
            chk.Scan("B");
            Assert.AreEqual(80, chk.GetTotal());
        }

        [TestMethod]
        public void ScanAItemAndAShouldReturn80()
        {
            var chk = new Checkout();
            chk.Scan("A");
            chk.Scan("A");
            Assert.AreEqual(100, chk.GetTotal());
        }

        [TestMethod]
        public void Scan3AItemsAndAShouldReturn130()
        {
            var chk = new Checkout();
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("A");
            Assert.AreEqual(130, chk.GetTotal());
        }
        [TestMethod]
        public void Scan2AItemsAndBShouldReturn45()
        {
            var chk = new Checkout();
            chk.Scan("B");
            chk.Scan("B");
            Assert.AreEqual(45, chk.GetTotal());
        }
    }

    public class Checkout : ICheckout
    {
        private int _total;
        public List<string> scannedItems = new List<string>();

        public void Scan(string sku)
        {
            var product = ProductCollInit.products.Find(m => m.Name == sku);
            scannedItems.Add(sku);
            _total += product.Price;
            if (scannedItems.FindAll(x => x == "A").Count() == 3)
            {
                _total -= 20;
            }
            if (scannedItems.FindAll(x => x == "B").Count() == 2)
            {
                _total -= 15;
            }
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
