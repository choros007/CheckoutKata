using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using CheckoutLib;

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
        [TestMethod]
        public void Scan3AItemsAnd1BItemShouldReturn160()
        {
            var chk = new Checkout();
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("B");
            Assert.AreEqual(160, chk.GetTotal());
        }
        [TestMethod]
        public void Scan3AItemsAnd2BItemShouldReturn175()
        {
            var chk = new Checkout();
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("B");
            chk.Scan("B");
            Assert.AreEqual(175, chk.GetTotal());
        }
        [TestMethod]
        public void Scan4AItemsAnd2BItemShouldReturn225()
        {
            var chk = new Checkout();
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("B");
            chk.Scan("B");
            Assert.AreEqual(225, chk.GetTotal());
        }
        [TestMethod]
        public void Scan6AItemsAnd2BItemShouldReturn305()
        {
            var chk = new Checkout();
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("B");
            chk.Scan("B");
            Assert.AreEqual(305, chk.GetTotal());
        }
        [TestMethod]
        public void Scan7AItemsAnd2BItemAnd2DItemsAnd2cItemsShouldReturn425()
        {
            var chk = new Checkout();
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("A");
            chk.Scan("B");
            chk.Scan("B");
            chk.Scan("C");
            chk.Scan("C");
            chk.Scan("D");
            chk.Scan("D");
            Assert.AreEqual(425, chk.GetTotal());
        }
    }
}