using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_04.Interface_Example_01
{

    // Developer --> 1

    // "Public" is the default Access Modifier Inside the InterFace. 
    // " Private" in not allowed for the signatures Only (Property , Method ) 
    internal interface IType
    {

        // What you can write inside the InterFace

        // 1. signature for property

        public int MyProperty { get; set; }

        // 2. Signature for method 

        public void MyMethod(); 

        // 3. Default Implmented Method [ C# 8.0 New Feature (.NET Core 3.1 [2019])]

        public void Print();

        // 4. Static Members [ C# 8.0 New Feature (.NET Core 3.1 [2019])]
        // 4.1 Static Fields
        // 4.2 Static Properties
        // 4.3 Static Method
        // 4.4 Static Events

    }
}
