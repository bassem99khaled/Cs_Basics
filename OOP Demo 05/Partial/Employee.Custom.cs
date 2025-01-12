using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Demo_05.Sealed;

namespace OOP_Demo_05.Partial
{
    //Developer 02
    internal partial class Employee : Parent
    {
     
        public string? Address { get; set; }
    
    public void DoSomeCode()
        {
            int X = 10;
            X++;
            Console.WriteLine(X);
        }


    }
}
