using System.Globalization;
using System.Text;

namespace Demo04
{
    internal class Demo04
    {
        static void Main(string[] args)
        {
            #region Loop statments


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{i} T");
            //}
            #endregion

            #region For - Foreach

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for(int i = 0; i < numbers.Length; i++) 
            //{
            //        Number += 10
            //if (Numbers[i] == 5)
            //    {
            //    break; // Continue //if i want to scape this number from printing
            //}
            //    Console.WriteLine(numbers[i]);
            //}   



            //class interface Ienummrable

            // if i want to print only the values in array use foreach but if i edit in array i must use for only

            //foreach (int Number in Numbers)
            //{

            //    Number += 10 //invalid
            //    Console.WriteLine(Number + 10);
            //}

            #endregion

            #region while - Do while

            //Console.WriteLine("Enter Even Number");
            //int Number = int.Parse(Console.ReadLine());

            //Console.WriteLine($"{Number} is even");


            //___________________________________________________
            //Do while best use becouse dont run the code every time

            //int Number;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter Even Number");
            //    //Number = int.Parse(Console.ReadLine());

            //    flag =int.TryParse(Console.ReadLine(), out Number);
            //}
            //while (Number % 2 == 1 || !flag);

            //Console.WriteLine($"{Number} is Even");



            //______________________________________________

            //int Number = 3;
            //bool Flag = false;
            //while(Number % 2 ==1 || !Flag)
            //{
            //    Console.WriteLine("Enter even Nubmer");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //}

            //Console.WriteLine($"{Number} is Even");

            #endregion

            #region String

            //Class => Reference Type
            // inmutable data Type [Value cant not be changed]
            //Array of Chars
            // A H M E D


            //string Name;
            //Name = new string("Ahmed");

            //Name = "ahmed";

            //string Name01 = "Ahmed";
            //string Name02 = "Ali";

            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name 02 HC : {Name02.GetHashCode()}");
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name 01 HC : {Name01.GetHashCode()}");

            //Name02 = Name01;

            //Console.WriteLine(" ************* Name02 = Name01 ***************");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name 02 HC : {Name02.GetHashCode()}");
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name 01 HC : {Name01.GetHashCode()}");

            //Name01 = "Mostafa";

            //Console.WriteLine(" ************* Name01 = Mostafa ***************");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name 02 HC : {Name02.GetHashCode()}");
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name 01 HC : {Name01.GetHashCode()}");



            //string Message = "hello";

            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());

            //Message += "Route";

            //Console.WriteLine(Message); 
            //Console.WriteLine(Message.GetHashCode());


            #endregion

            #region StringBulider

            //StringBuilder Message;

            //Message = new StringBuilder("Ahmed");

            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());

            //Message.Append("Route");

            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());


            #endregion

            #region StringBuilder Methods


            //StringBuilder Message = new StringBuilder("Welcome");

            //Message.Append("To Route");
            //Message.AppendLine("Mostafa");
            //Message.Append("Hany");
            //Console.WriteLine(Message);

            //Message.Remove(0, 7);
            //Console.WriteLine(Message);

            //Message.Insert(0, "Hello");
            //Console.WriteLine(Message);


            //Console.WriteLine();
            //int Age = 10;
            //String Name = "Ali";
            //Message.AppendFormat("Name ; {0} , Age : {1} " , Name , Age);

            //Message.AppendJoin("/", "Mostafa", "hany", "Mohamed", 2);
            //Console.WriteLine(Message);

            #endregion

            #region Array 1 D

            //int[] Numbers = new int[3] { 1, 2, 3 };
            //int[] Numbers = new int[] { 1, 2, 3 };
            //int[] Numbers = { 1, 2, 3 };

            //int[] Numbers = new int[3];

            //Numbers[0] =1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine($"Enter Element NUmber {i+1}");
            //    Numbers[i] = int.Parse( Console.ReadLine() );
            //}

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //Console.WriteLine(Numbers.Length);
            //Console.WriteLine(Numbers.Rank);

            #endregion

            #region Array 2 D

            //int[,] Marks = new int[3, 5]; //{ { 1, 2, 3, 4, 5 }, { 5, 50, 52, 21, 11 }, { 1, 2, 3, 4, 5 } };

            ////Console.WriteLine( Marks.Length );
            ////Console.WriteLine( Marks.Rank );
            ////Console.WriteLine( Marks.GetLength( 0 ) );
            ////Console.WriteLine( Marks.GetLength( 1 ) );

            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter Data Student ({i + 1})");
            //    for (int k = 0; k < Marks.GetLength(1); k++)
            //    {
            //        bool flag;
            //        Console.WriteLine($"Enter Grade subject [{k + 1}]");
            //        // Marks[i,k] = int.Parse(Console.ReadLine());
            //        flag = int.TryParse(Console.ReadLine(), out Marks[i, k]);


            //        //if(flag && Marks[i,k] >= 0)
            //        //{
            //        //    k++;
            //        //}

            //        k = flag && Marks[i, k] >= 0 ? ++k : k;
            //    }
            //}

            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter Data Student ({i + 1})");
            //    for (int k = 0; k < Marks.GetLength(1); k++)
            //    {
            //        Console.WriteLine($"Enter Grade subject [{k + 1}]");
            //        Console.WriteLine(Marks[i, k]);

            //    }
            //}
            //Console.Clear();
            //for (int i = 0; i < Marks.Length; i++)
            //{
            //    Console.WriteLine(Marks[i / Marks.GetLength(1), i % Marks.GetLength(1)]);
            //}
            #endregion

            #region Judged Array

            //int[][] number = new int[3][];

            //number[0] = new int[3]
            //{ 1,2,3};
            //number[1] = new int[2]
            //{ 2,3};
            //number[2] = new int[1]
            //{ 4 };


            //for (int i = 0; i < number.Length; i++)
            //{
            //    for (int j = 0; j < number[i].Length; j++)
            //    {
            //        Console.WriteLine(number[i][j]);
            //    }
            //}
            #endregion

        }
    }
    }

