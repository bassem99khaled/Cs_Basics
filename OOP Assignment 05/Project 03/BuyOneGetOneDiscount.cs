using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_05.Project_03
{
    internal class BuyOneGetOneDiscount : Discount
    {

       
            public BuyOneGetOneDiscount()
            {
                Name = "Buy One Get One 50% Off";
            }

            public override decimal CalculateDiscount(decimal price, int quantity)
            {
                int discountedItems = quantity / 2;
                return (price / 2) * discountedItems;
            }
        
    }
}
