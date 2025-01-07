using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_04.InterFace_Example_02
{
    internal class TypeC : Iseries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 4;
        }

        public void Reset()
        {
            Current = 0;        }
    }
}
