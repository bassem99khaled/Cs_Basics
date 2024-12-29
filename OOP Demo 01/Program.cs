using System.Data.SqlTypes;

namespace OOP_Demo_01
{
    internal class Program
    {

        //enum Gender
        //{
        //    Male = 1, Female = 2
        //}
        //enum Days
        //{
        //    Saturday,
        //    sunday,
        //    monday,
        //    tuesday,
        //    wednesday,
        //    thursday,
        //    friday,
        //}

        //enum Grades
        //{
        //    A, B, C, D, E, F
        //}

        //enum Branches : Byte // 0 : 255
        //{
        //    NasrCity, Maadi = 251, Alex, Dokki, Emhaas, SmartVillage
        //}
        //[Flags]
        //enum permissions
        //{
        //    Delete = 1, excute = 2, read = 4, write = 8
        //}

        static void Main(string[] args)
        {


            #region Exeption handling

            //DoSomeCode();

            // Exceptions

            //FormatExecption
            // divideByXeroExecption
            // IndexOutOfRangeExecption

            // 1. System excepions 
            // 1.1 Format Exception
            // 1.2 Index out of range Exception
            // 1.3 Null Reference Exception
            // 1.4 Invalid Operation Exception
            // 1.5 Arithmetic Exception
            // 1.5.1 Divided By Zero Exception
            // 1.5.2 OverFlow Exception
            // 2. Application Exception

            //try
            //{
            //    DoSomeProtectiveCode();
            //    throw new Exception();
            //}
            //catch
            //(Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}


            //Finally
            //    {
            //    // Close - free - Delete - Dealocate Unmanged Recources
            //    // open file
            //    // open Connection DataBase
            // COnsole.WriteLine("Finally")
            //     }
            //Console.WriteLine(" After Try catch");

            //     public static void DoSomeCode()
            //{
            //    try
            //    {
            //        int x, y, z;
            //        x = int.Parse(Console.ReadLine()); //FormatExecption
            //        y = int.Parse(Console.ReadLine());

            //        z = x / y; // divideByXeroExecption

            //        int[] Numbers = { 1, 2, 3 };

            //        Numbers[10] = 100; // IndexOutOfRangeExecption
            //    }
            //    //CLR Create Object From Exception
            //    catch
            //    (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        //Log in File
            //        // Storge DB
            //    }
            //}

            //public static void DoSomeProtectiveCode()
            //{

            //    int x, y, z;
            //    bool flag;
            //    //x = int.Parse(Console.ReadLine()); //FormatExecption
            //    do
            //    {
            //        Console.WriteLine("Enter First Number");
            //        flag = int.TryParse(Console.ReadLine(), out x);

            //    } while (!flag);

            //    //y = int.Parse(Console.ReadLine());
            //    do
            //    {
            //        Console.WriteLine("Enter Second Number");
            //        flag = int.TryParse(Console.ReadLine(), out y);
            //    } while (!flag || y == 0);
            //    z = x / y; // divideByXeroExecption

            //    int[] Numbers = { 1, 2, 3 };
            //    if (Numbers.Length > 10)
            //    {
            //        Numbers[10] = 100; // IndexOutOfRangeExecption
            //    }



        }
        #endregion

            #region Access Modifiers


        // its project and external project [import]

        // TypeA TypeA = New TypeA();
        // TypeA.x = 10;

        private int X;  // only can show in class in same project only clas scope only

        internal int Y; // Class scope and its project
        public int z;   // can access in any clas and peoject

        #endregion

            #region Enum
        #region Ex01
        //string Day = "Hamada";
        //Days Day = Days.sunday;

        //    Grades grade = Grades.A;
        //    if(Grade == Grades.A)
        //        {
        //        Console.Writeline(":)");
        //        }
        //else
        //{
        //Console.WriteLine(":(");
        //    }
        #endregion

        #region Ex02

        //Grades grade = (Grades)10; // explicet casting not safe can send something not define
        //Console.WriteLine(grade); // 10

        //    enum Roles
        //{
        //    Admin = 10 , viewer = 20 , Editor = 30
        //}

        #endregion

        #region Ex03

        //  Grades Grade = (Grades)Enum.Parse(typeof(Grades), Console.ReadLine());

        //Enum.TryParse(Typeof(Grades).Console.ReadLine(), out object Result);
        //Grades Grade = (Grades)Result;

        //Console.WriteLine(Result);

        #endregion

        #region Ex04
        // String Gender = "Male";

        //Enum.TryParse<Gender>(Gender, SqlTruncateException, out Gender Result);

        #endregion

        //public string Name;
        //public int Age;
        //public decimal Salary;
        //public Gender gender; // Male - Female / 1 - 0
        //                      // Admin , Viewer , Editor
        //public Roles Role;
        //public permissions
        #endregion

            #region Premission

        //    Employee employee = new Employee();
        //    employee.name = "Ali";
        //     employee.Permissions = (permissions)1;    

        //        Console.WriteLine(employee.Permissions); // Delete , Execute


        //        // XOR

        //        employee.Permissions = employee.Permissions ^ Permissions.Read;
        //        Conosole.WriteLine(employee.Permissions); // Delete , Execute , Read

        //        // &

        //        if(employee.Permissions&Permissions.Read) == Permissions.Read)
        //        {
        //        Console.WriteLine("Read is exist");
        //        }
        //else
        //{
        // employee.Permissions = employee.Permissions ^ Permissions.Read;
        //    }

        // OR
        //employee.Permissions = employee.Permissions | permissions.Read;
        #endregion

            #region Struct 

            //internal struct point

            /// what you can write inside the Struct or Class
            /// // 1. Attributes[Fields] => Member Variable <summary>
            /// what you can write inside the Struct or Class
            /// </summary>
        //public int x;
        //public int y;
        /// 2. Functions [ Constructors , Getter Setter , method]
        /// Constructor Special Function
        /// 1. Name Constructor Same Name Class or struct
        /// 2. no return
        /// 3. Properties [ Full Property , Automatic Property Indexer ]
        /// 4. Events

    //     public point(int _x ,int _y)
    //    {
    //             x = _x;
    //             y = _y;
    //}
    //    public point(int number)
    //        { 
    //      x = y = number 
    //    }

        //point P01;
        //P01.x = 10;
        //P02.y=20;
        //    Console.WriteLine(P01.x);

        //P01 = new point(2);

        //Console.WriteLine(P01.x);


        #endregion



    }
 }

