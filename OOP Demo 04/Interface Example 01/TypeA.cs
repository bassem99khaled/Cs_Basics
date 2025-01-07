using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_04.Interface_Example_01
{
    //Developer --> 2
    internal class TypeA : IType
    {
        private int MyAttribute;
        public int MyProperty
        {
            get { return MyAttribute; }
            set { MyAttribute = value; }
        }

        public void MyMethod()
        {
            Console.WriteLine("Hello World");  
                }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
