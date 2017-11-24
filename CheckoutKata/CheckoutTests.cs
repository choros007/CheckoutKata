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
            chk.Scan("B");
            Assert.AreEqual(50, chk.GetTotal());
        }

        [TestMethod]
        public void ScanBItemShouldReturn30()
        {
            var chk = new Checkout();
            chk.Scan("B");
            Assert.AreEqual(30, chk.GetTotal());
        }
    }

    public class Checkout
    {
        private int _total;
        public void Scan(string sku)
        {
            _total = 50;
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
