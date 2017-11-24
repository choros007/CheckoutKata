using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            if(sku == "A")
            {
                _total = 50;
            }
            else if(sku == "B")
            {
                _total = 30;
            }
            else if (sku == "C")
            {
                _total = 20;
            }
            else if (sku == "D")
            {
                _total = 15;
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
}
