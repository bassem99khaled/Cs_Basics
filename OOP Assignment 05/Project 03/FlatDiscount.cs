using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_05.Project_03
{
    internal class FlatDiscount : Discount
    {
      
            private decimal flatAmount;

            public FlatDiscount(decimal flatAmount)
            {
                this.flatAmount = flatAmount;
                Name = $"Flat Discount of ${flatAmount}";
            }

            public override decimal CalculateDiscount(decimal price, int quantity)
            {
                return flatAmount * Math.Min(quantity, 1);
            }
        
    }
}
