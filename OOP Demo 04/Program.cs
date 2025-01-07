using OOP_Demo_04.Interface_Example_01;

namespace OOP_Demo_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

#region Interface_Example_01
            IType reference;

            // Declare for Refence of Type "IType" , Containg Garbag Value
            // this Reference 'type' Can Refer to an Object of any "Type Implementing Itype InterFace"
            //  CLR will Allocate 4 UnInitialized Bytes in Stack For this Reference
            //  CLW will Allocate 0 Byte in Heap.

            // reference = /*new IType()*/   --> INVALID 

            reference = new TypeA(); 
            reference.MyProperty = 10;
            reference.MyMethod(); // Hello World
            reference.Print();  // Default Implemented method

            TypeA typeA = new TypeA();
            reference.MyProperty = 10;
            reference.MyMethod(); 
            reference.Print();
            #endregion
        }
    }
}
