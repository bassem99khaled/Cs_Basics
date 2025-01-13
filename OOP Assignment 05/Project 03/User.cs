using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_05.Project_03
{
    internal abstract class User
    {
        public string Name { get; protected set; }
        public abstract Discount GetDiscount();
    }
}
