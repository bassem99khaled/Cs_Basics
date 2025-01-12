using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_05.Sealed
{
 class Parent
    {

        public virtual int Salary { get; set; }

        public sealed void Print()
        {
            Console.WriteLine("I am Base");
        }
    }

    class Child : Parent
    {
        // Sealed Property
        public sealed  override int Salary
        {
            get {  return base.Salary; }
            set { base.Salary = value < 5000 ? 5000 : value; }
        }
    
    }

    // Sealed class
    sealed class GrandChild : Child  // Sealed Class cant inhirte from them or override
    {
        public override int Salary
        { 
            get { return base.Salary; }
            set { base.Salary = value < 6000 ? 600 : value; } 
        }
    }


}
