using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_05.Project_03
{
    internal class GuestUser : User
    {
        public GuestUser(string name)
        {
            Name = name;
        }

        public override Discount GetDiscount()
        {
            return null; 
        }
    }
}
