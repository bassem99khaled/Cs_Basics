using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_02
{
    internal class Car
    {
             #region Attributes

        //private int id = default;           // 4 Byte
        //private string? model = default;    // 4 Byte
        //private double speed = default;     // 8 Byte

            #endregion


            #region Properties

        //public double Speed
        //{
        //    get { return speed; }
        //    set {  speed = value;}

        //}

        //public string? Model
        //{
        //    get { return model; }
        //    set { model = value; }
        //}

        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        #endregion


            #region Constructors
        //if no User-Defined Constructor Exists , Compiler will always Generate "Empty Parameterless Constructor" [Do Nothing]
        //public Car()
        //{


        //}

        // if you Defined a Constructor,
        // Compiler Will no Longer Generate " Empty Parameterless Constructor"


        //public Car(int id, string? model, double speed)
        //{
        //    this.id = id;
        //    this.model = model;
        //    this.speed = speed;

        //    Console.WriteLine("Constructor 01");
        //}

        //public Car(int id ,string? model) : this(id , model , 120) // Constructor chaining
        //{
        //    ///this.id = id;
        //    ///this.model = model;
        //    ///this.speed = 120;

        //    Console.WriteLine("Constructor 02");
        //}

        //public Car(int id) : this (id , "Hyndai Verna 2010" , 100)
        //{
        //    ///this.id=id;
        //    ///this.model = "Hyndai Verna 2010";
        //    ///this.speed = 100;

        //    Console.WriteLine("Constructor 03");
        //}

        #endregion


             #region Methods

        //public override string ToString()
        //{
        //    return $"Id = {id} \n Model = {model} \n Speed = {speed}";
        //}

        #endregion
        
    }
}
