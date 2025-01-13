using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_05.Project_03
{
    internal class PercentageDiscount : Discount
    {
       
            private decimal percentage;

            public PercentageDiscount(decimal percentage)
            {
                percentage = percentage;
                Name = $"{percentage}% Percentage Discount";
            }

            public override decimal CalculateDiscount(decimal price, int quantity)
            {
                return price * quantity * (percentage / 100);
            }
        
    }
}
