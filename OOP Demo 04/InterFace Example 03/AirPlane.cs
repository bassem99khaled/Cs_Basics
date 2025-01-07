using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_04.InterFace_Example_03
{
    internal class AirPlane : Vechile, ImoveAble, IFlyAble
    {
      
        void ImoveAble.Forward()
        {
            Console.WriteLine("Airplane is move forward on Ground");
        }

        void IFlyAble.Forward()
        {
        Console.WriteLine("Airplane is move Forward on Air");
        }

    


      
    }
}
