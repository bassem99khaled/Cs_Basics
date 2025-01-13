﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_05.Project_03
{
    internal class RegularUser : User
    {
     
            public RegularUser(string name)
            {
                Name = name;
            }

            public override Discount GetDiscount()
            {
                return new PercentageDiscount(5);
            }
        
    }
}
