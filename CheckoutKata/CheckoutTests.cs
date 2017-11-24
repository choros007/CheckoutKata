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
            Assert.AreEqual(50, chk.Scan("A"));
        }
    }

    public class Checkout
    {
        public int Scan(string sku)
        {
            return 0;
        }
    }
}
