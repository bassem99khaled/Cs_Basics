using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_Assignment_01
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            #region      1.	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            // Then, write a C# program that prints out all the days of the week using this enum.




            //enum WeekDays
            //{
            //    Monday,
            //    Tuesday,
            //    Wednesday,
            //    Thursday,
            //    Friday,
            //    Saturday,
            //    Sunday
            //}


            //        Console.WriteLine("Days of the Week:");


            //        foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //        {
            //            Console.WriteLine(day);
            //        }

            #endregion


            #region  2.Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter)
            //as its members.Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            //Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)


            //      enum Season
            //{
            //    Spring,
            //    Summer,
            //    Autumn,
            //    Winter
            //}

            //Console.WriteLine("Enter a season name:");
            //    string input = Console.ReadLine();


            //if (Enum.TryParse(input, true, out Season selectedSeason))
            //{

            //    switch (selectedSeason)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;

            //    }
            //}


            #endregion


            #region 3.	Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            // ⮚	Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable



            //[Flags]
            //enum Permissions
            //{
            //    None = 0,
            //    Read = 1,
            //    Write = 2,
            //    Delete = 4,
            //    Execute = 8
            //}



            //        Permissions userPermissions = Permissions.None;


            //        userPermissions |= Permissions.Read;
            //        userPermissions |= Permissions.Write;
            //        Console.WriteLine($"Current Permissions: {userPermissions}");


            //        if ((userPermissions & Permissions.Read) == Permissions.Read)
            //        {
            //            Console.WriteLine("Read permission is granted.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Read permission is not granted.");
            //        }


            //        userPermissions &= ~Permissions.Read;
            //        Console.WriteLine($"Permissions after removing Read: {userPermissions}");


            //        if ((userPermissions & Permissions.Read) == Permissions.Read)
            //        {
            //            Console.WriteLine("Read permission is granted.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Read permission is not granted.");
            //        }


            #endregion


            #region 4.Create an enum called "Colors" with the basic colors(Red, Green, Blue) as its members.
            //Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.



            //enum Colors
            //{
            //    Red,
            //    Green,
            //    Blue
            //}


            //        Console.WriteLine("Enter a color name:");
            //        string input = Console.ReadLine();


            //        if (Enum.TryParse(input, true, out Colors selectedColor))
            //        {
            //            Console.WriteLine($"{input} is a primary color.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{input} is not a primary color.");
            //        }


            #endregion


            #region 5.	Create a struct called "Point" to represent a 2D point with properties "X" and "Y". 
            //Write a C# program that takes two points as input from the user and calculates the distance between them.



  
        //struct Point
        //{
        //    public double X, Y;

        //    public Point(double x, double y)
        //    {
        //        X = x;
        //        Y = y;
        //    }
        

       
        //        Console.WriteLine("Enter first point (X Y):");
        //        var p1 = ReadPoint();

        //        Console.WriteLine("Enter second point (X Y):");
        //        var p2 = ReadPoint();

        //        double distance = Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
        //        Console.WriteLine($"The distance between the points is: {distance:F2}");
        //    }

        //    static Point ReadPoint()
        //    {
        //        var input = Console.ReadLine().Split();
        //        return new Point(double.Parse(input[0]), double.Parse(input[1]));
        //    }
     



    #endregion


}
    }
    }