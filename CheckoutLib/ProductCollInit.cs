using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutLib
{
    public class ProductCollInit
    {
        public static List<Product> products = new List<Product>
        {
            new Product
            {
                Name = "A",
                Price = 50,
                DiscountedPrice = 20,
                NumberOfItemsForDiscount = 3
            },
            new Product
            {
                Name = "B",
                Price = 30,
                DiscountedPrice = 15,
                NumberOfItemsForDiscount = 2
            },
            new Product
            {
                Name = "C",
                Price = 20,
                DiscountedPrice = 0,
                NumberOfItemsForDiscount = 0
            },
            new Product
            {
                Name = "D",
                Price = 15,
                DiscountedPrice = 0,
                NumberOfItemsForDiscount = 0
            }
        };
    }
}
