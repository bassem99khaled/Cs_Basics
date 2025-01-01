using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_02.Association.Composition
{
    internal class Product
    {

        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsOfStock { get; set; }



    }
}
