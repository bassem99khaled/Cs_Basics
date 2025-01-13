using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_05.Project_03
{
    internal abstract class Discount
    {
            public string Name { get; protected set; }
            public abstract decimal CalculateDiscount(decimal price, int quantity);
        

    }
}
