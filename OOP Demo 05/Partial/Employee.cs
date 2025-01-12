using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Demo_05.Sealed;

namespace OOP_Demo_05.Partial
{
    //Developer 01
    internal partial class Employee : Parent
    {
        public int Id { get; set; }

        public string? Name { get; set; }
         
        public int? Age { get; set; }

        partial void DoSomeCode();
        public void Test()
        {
            DoSomeCode();
        }
    }
}
