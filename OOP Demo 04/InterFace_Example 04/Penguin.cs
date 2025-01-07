using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_04.InterFace_Example_04
{
    internal class Penguin : IBird
    {
        void IBird.Eat()
        {
            throw new NotImplementedException();
        }

     

        void IBird.Walk()
        {
            throw new NotImplementedException();
        }
    }
}
