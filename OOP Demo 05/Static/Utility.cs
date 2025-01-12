using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_05.Static
{

    // Static Class
    // is a just Container for static member [ Attrubyte , Property , Constructor , method ]
    // and constants
    // you cant create Object from this class (Helper Class)
    // no Iheritance for this class
    internal class Utility
    {
        public int x {  get; set; }
        public int y { get; set; }


        //Object member Constructor : Non-Static Constructor
        public Utility(int x , int y )
            
        { 
        this.x = x;
                this.y = y;
            // pi = 3.14;  is not the right place for initializing the static attributes.
        }


        // static Constructor [ max only oen per Class ]
        // // u Cant Specify Acces Modifier Or Parameters for the Stataic Constructor
        // will be Called just only One time Per Class lifeTime Before the First Usage of the Class
        // the Usages of the Class as Fllowing :
        // 1. Crearte Object From the class or from another Class "Inheriting from this Class"
        // 2. Call Static property
        // 3. Call Static Method

        static Utility()
        {
           // this.pi = 3.14;
        }
        public override string ToString()
        {
            return base.ToString();
        }

        // object member method Static method

        public static  double CmToInch(double cm)
        {
            return cm / 2.54;
        }


        // Object Helper Attribute

   //
   // private static readonly double pi = 3.14;
        // CLR will Initilize Each and every static attribute with its Datatype Default Value
        // Before the first Usage of the Class

        // 1. Class member attribute : Static attribute

        // 2. Constant
        double const double pi = 3.14;

        // Class member Property : non static Property : [ Must deal with one of the Following
        // Must Deal with one of the fallowing
            //1. Static attribute
            //2. Constant
        public double PI
        {
            get { return pi; }
           
        }
        public double CalcCircleArea(double Radius)
        {
            return Utility.PI * Radius * Radius;
        }
    }
}
