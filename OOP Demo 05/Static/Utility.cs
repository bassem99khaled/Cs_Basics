using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_05.Static
{
    internal class Utility
    {
        public int x {  get; set; }
        public int y { get; set; }

        public Utility(int x , int y)
            
        { 
        this.x = x;
                this.y = y;
        
        }

        public override string ToString()
        {
            return base.ToString();
        }

        // object member method

        public double CmToInch(double cm)
        {
            return cm / 2.54;
        }

    }
}
