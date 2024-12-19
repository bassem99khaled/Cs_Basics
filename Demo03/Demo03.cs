using System.Net.Sockets;

namespace Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Value type Casting
            #region Implicit Casting _ Safe Casting
            //int X=4; // 4 bytes
            //long y = /*(long)*/X;
            #endregion

            #region Explict Casting _ UnSafe Casting

            //Long X = 1011010101010; // 8 bytes

            //int Y;

            //checked
            //{
            //    Y = (int)X;
            //}
            //Console.WriteLine(Y);


            //int X = 88;
            //double X = 88.8;
            //int Y = (int)X;

            //Console.WriteLine(Y);
            #endregion

            #region Parse {Convert From String to Any DataType}

            //int Number = int.Parse(Console.ReadLine());


            //Console.WriteLine("Enter Data User");

            //Console.Write("Enter Name : ");
            //string Name = Console.ReadLine();

            //Console.WriteLine("Enter Age : ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter Salary : ");
            //double Salary = Convert.ToDouble(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine("Name :" +  Name + "Age" + Age + "Salary" + Salary);

            #endregion

            #region Operators
            #region Unary Operators [ ** , -- ]

            //int x = 5;
            //x++;
            //++x;
            //Console.WriteLine(++x);
            //Console.WriteLine(x++);

            //Console.WriteLine(--x);
            //Console.WriteLine(x--);
            #endregion
            #region Binary Operator

            //int sum, mul, sub, div, mod;

            //int A = 10;
            //int B = 5;


            //sum = A+ B; // 15
            //sub = A - B; // 5
            //div = A / B; //2
            //mul = A * B; // 50
            //mod = A % B; // 0

            //Console.WriteLine(sum);

            #endregion

            #region Assignment Operator
            //int X = 10

            //     X += 10; // x= x+10
            //     X -= 10; // x= x-10
            //     X *= 10; // x= x*10
            //     X /= 10; // x= x/10
            //     X %= 10; // x= x%10
            #endregion
            #region relational Operator

            //int A = 5;
            //int B = 10;

            //Console.WriteLine(A< B);
            #endregion
            #region Logical Operators [ Short circut]

            //Console.WriteLine(!ture);

            //Console.WriteLine(true && false);

            // True && True => true
            // True && False => False
            // False && True => False
            // False && false => False


            //Console.WriteLine(true || false);

            // True || True => true
            // True || False => True
            // False || True => True
            // False || false => False

            #endregion

            #region Bitwise Operators [ long Circut]
            //Console.WriteLine(!ture);

            //Console.WriteLine(true & false);

            // True & True => true
            // True & False => False
            // False & True => False
            // False & false => False


            //Console.WriteLine(true | false);

            // True | True => true
            // True | False => True
            // False | true => True
            // False | false => False

            #endregion
            #region Ternary Operator [ Conditional Operator]

            // 4

            //int x = 3;
            
            //string Message = x >4 ? "x Greater than 4" : "X Less than or equal 4"
            //  Console.WriteLine(Message);

            #endregion



            #endregion

            #region Operator Periorety
            /*
             * 1.unary operator [PreFix]
             * 2. ()
             * 3. * / %
             * 4. + - 
             */


            //int A = 20;
            //int B = 15;
            //int C = 10;
            //int D = 5;

            //int Result;

            //Result = (A + B) * C / D; //

            //Result = A++ * C;

            //Result = ++A * C;

            //Console.WriteLine(Result);

            #endregion

            #region String Formating

            // Equation = X + Y = Result
            // Equation = 10 + 5 = 15

            //int X = 15;
            //int Y = 10;

            //int Result = X + Y;
            //Console.WriteLine("Equation :" + X + " + " + Y + "= "+ Result);
            //String Name = "Ahmed";
            //  Name = "Ali";

            #endregion

            #region 1. Composite Format
            //String Message = string.Format("Equation = {0} + {1} ={2}", x, Y, Result);
            //Console.WriteLine(Message);
            //Console.WriteLine("Equation = {0} + {1} = {2}" , X , Y , Result);
            #endregion

            #region String Manipolition

            // string Interpolation => $

            //Console.WriteLine($"Equation = {x} + {Y} = {Result}");
            #endregion
            #endregion


            #region If Else - Switch Case
            //Console.WriteLine("Enter Month Number");
            //int MonthNumber = int.Parse( Console.ReadLine() );

            // 1=> month is jan
            // 2=> month is Feb
            // 3=> month is Mar
            // Invalid input

            //if (MonthNumber == 1)  // if only one line in condition i can do with out {}
            //{
            //    Console.WriteLine("month is Jan"
            //}
            //else if (MonthNumber == 2) {
            //    Console.WriteLine("month is Feb");
            //}
            //else if (MonthNumber == 3) {
            //    Console.WriteLine("month is Mar");
            //}
            //else
            //{
            //    Console.WriteLine("invalid Input");
            //        }

            //switch(MonthNumber
            //    {
            //         case 1:
            //             Console.WriteLine("Month is jan");
            //         case 2:
            //             Console.WriteLine("Month is Feb");
            //        case 3: 
            //             Console.WriteLine("month is Mar");
            //             break;
            //        default:
            //            Console.WriteLine("Invalid input");
            //            break ;
            //    }
            #endregion

            #region IF_ Switch Adv

            //Console.WriteLine("Enter Name");
            //string Name = Console.ReadLine();

            //if (Name == "Mostafa || Name == "mostafa")
            //{
            //    Console.WriteLine("Hello Mostafa");
            //}
            //else if (Name == "Aliaa")
            //{
            //    Console.WriteLine("Hello Aliaa");
            //}
            //else if(Name == "Ahmed")
            //{
            //    Console.WriteLine("Hello Ahmed");
            //}

            //switch(Name)
            //{
            //    case "Mostafa":
            //    case "mostafa":
            //        Console.WriteLine("Hello Mostafa");
            //        break;
            //    case "Aliaa":
            //        Console.WriteLine("Hello Aliaa");
            //        break;
            //    case "Ahmed":
            //        Console.WriteLine("Hello Ahmed");
            //        break;

            //}

            #endregion

            #region GoTo

            //Console.WriteLine("Enter Option");
            // 3000 => "Option 01" , "option 02" . "Option 03 "
            // 2000 => "Option 01" , "Opiton 02 "
            // 1000 => "Option 01"

            //int Option = int.Parse(Console.ReadLine());

            //            switch(Option)
            //            {
            //                case 3000:
            //                    Console.WriteLine("Option 03");
            //                    goto case 2000;

            //                    break;
            //                case 2000:
            //                    Console.WriteLine("Option 02");
            //                    goto case 1000;
            //                    break;
            //`               case 1000:
            //                    Console.WriteLine("Option 01")
            //                        break;

            //            }
            #endregion

            #region Evaluation Of switch case

            #region C# 06
            //Console.WriteLine("Enter Age");
            //int Age = int.Parse(Console.ReadLine());    

            //switch(Age)
            //{
            //    case > 22
            //            Console.WriteLine("Age Greater Than 22");
            //        break;
            //    case < 22
            //        Console.WriteLine("Age Less Than 22");
            //        break;
            //        default:
            //        Console.WriteLine("Age Equal 22");
            //        break;
            //}
            #endregion

            #region C# 07

            //Object obj = new object();
            //obj = "Mostafa";
            //obj = 10;
            //obj = true;


            //switch(obj)
            //{
            //    case int Number when Number >10 && Number <20:
            //        Console.WriteLine($"{Number} is int");
            //        break;
            //    case String Name:
            //        Console.WriteLine($"{Name} is String");
            //        break;
            //    case bool Flag:
            //        Console.WriteLine($"{Flag} is Bool");
            //        break;
            //}


            #endregion

            #region C# 08
            #region EX01
            //Console.WriteLine("Enter Option");
            //int opation = int.Parse( Console.ReadLine() );

            //string message = opation switch
            //{
            //    1 => "Option 01",
            //    2 => "Option 02",
            //    3 => "Option 03",
            //    _ => " invalid"
            //};
            #endregion
            #region Ex02

            //Empolyee E01 = new Employee();
            //E01.Name = "Ali";
            //E01.Id = 10;
            //E01.Age = 22;

            //string Massege = E01 switch
            //{
            //    { id: 10, Name: "Alaa", Age: 22 } => $"{E01.Id} : {E01.Name} : {E01.Age}",
            //    { id: 10, Name: "Ali", Age: 22 } => $"{E01.Id} : {E01.Name} : {E01.Age}",
            //    { id: 20, Name: "Mona", Age: 20 } => $"{E01.Id} : {E01.Name} : {E01.Age}",
            //};

            //Console.WriteLine(Message);
            #endregion
            #endregion

            #region C# 09
            //Empolyee E01 = new Employee();
            //E01.Name = "Ali";
            //E01.Id = 10;
            //E01.Age = 22;

            //string Massege = E01 switch
            //{
            //    { Age: > 22 and < 25 } => $"{E01.Id} : {E01.Name} : {E01.Age}",
            //    { Age: 22 or 23 } => $"{E01.Id} : {E01.Name} : {E01.Age}",
            //    { Age: not 20 } => $"{E01.Id} : {E01.Name} : {E01.Age}",
            //};

            //Console.WriteLine(Message);

            #endregion
          
            #endregion




        }
    }
}
