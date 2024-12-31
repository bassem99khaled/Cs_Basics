using OOP_Demo_02.Encapsulation;

namespace OOP_Demo_02
{
    internal class Program
    {
        //Entry Point
        static void Main(string[] args)
        {
            #region Struct
            //    Point P1;
            //    //Declare for Object of type "Point
            //    //// CLR Will Allocate 8 UnInitialized Bytes in Stack.

            //    P1 = new Point(1 , 2);
            //    // NEW --> IS JUST FOR THE CONSTRUCTOR selection that will initialize the struct object


            //    Console.WriteLine(P1); // ( 1 , 2 )  // Most use but making Boxing 


            //    Console.WriteLine(P1.ToString());  // x= 1 , y = 2
            //}
            #endregion

            #region Encapsulation


            //Employee employee = new Employee( 100, " Ahmed Nasr" , 10_000);

            //{
            //    Name = " Ahmed Mahmoud"
            //}

            //employee.id = 2002; // set id throgh the field itself

            //Console.WriteLine(employee.id);
            //Console.WriteLine(employee.code); // get id throght the field itself


            //employee.SetId(2002); // setter

            //employee.Name = " Ibrahim ali";
            //Console.WriteLine(employee.Name);

            //Console.WriteLine(employee.Getid); // Getter



            #endregion

            #region Encapsulation (Indexer)

            //string name = "Ahmed";

            //// char[] Name = { 'A', 'h', 'm', 'e', 'd' };

            //Console.WriteLine(name[0]); // A


            //PhoneBook note = new PhoneBook(10);
            //note.addperson(0, "Ahmed", 11111);
            //note.addperson(0, "Nadia", 22222);
            //note.addperson(0, "Osama", 33333);
            //note.addperson(0, "Amany", 44444);


            ////note.SetNumber("Ahmed", 99999);
            ////Console.WriteLine(note.GetNumber("Ahmed"));

            ////Console.WriteLine(note["Ahmed"]);
            ////Console.WriteLine(note.GetNumber("Ahmed");

            //for(int i = 0; i < 10; i++) 
            //{
            //    Console.WriteLine(note[i]);

            //string Name = "Agmed";
            //Console.WriteLine(Name[0]); // A
            //Name[0] = 'x'; // not allawed
            #endregion
        }
    }
}
