using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutLib
{
    public class Checkout
    {
        private int _total;
        public List<string> scannedItems = new List<string>();

        public void Scan(string sku)
        {
            var product = ProductCollInit.products.Find(m => m.Name == sku);
            scannedItems.Add(sku);
            _total += product.Price;
            if (scannedItems.FindAll(x => x == sku).Count() == product.NumberOfItemsForDiscount)
            {
                _total -= product.DiscountedPrice;
                scannedItems.RemoveAll(x => x == sku);
            }
        }

        public int GetTotal()
        {
            return _total;
        }
    }
}
