using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_02.Encapsulation
{
    internal class Employee
    {
        // *** Encapsulation : separates Data Definition [field] from its use [ Getters & Setters]
        #region Attributes

        private int id;
        private string name;    
        private int salary;
       // private decimal Deduction; // Derivid Attribute
        #endregion

        #region    1. Applying Encapsulation throght Getters & Setters [old approach]

        // Getter
        //public int Getid()
        //{
        //    return id;
        //}

        ////setter
        //public void SetId(int Value)
        //{
        //    id = Value > 1000 && Value < 10_000? Value: 9999; //

        //}
        #endregion

        #region Properties 
        //2. Applying Encapsualtion through Properties [ New Approach] (Recommended)


        // 2.1 Full Property
        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        //public string? Name
        //{
        //    get
        //    { 
        //        return name;
        //    }
        //    //set
        //    //{
        //    //    // Data validation
        //    //    Name = value?.Length > 10? value: value?.Substring( 0, 10);
        //    //    Name = value is null? null : value.Length <= 10? Value : Value.Substring(0, 10); // best in coding use
        //    //}

        //    set
        //    {
        //        name = ValiddateName(value);
        //    }

        //    //init // change of set
        //    //{
        //    //    Name = value is null ? null : value.Length <= 10 ? Value : Value.Substring(0, 10);
        //    //}
        //}

        //public decimal Salary
        //{
        //    get
        //    {
        //        return salary;
        //    }
        //    set
        //    {
        //       Salary = ValiddateSalary(value);
        //    }
        //}

        //// read only proparty
        //public decimal Deduction
        //{
        //    get { return salary * .2M; }
        //}

        // 2.2 Automatic Property
        /// <summary>
        ///  Compiler will Generate Backing Field 'gidden private Attribute'
        ///  int <Age>_backingfield;
 
        //private int age;
        //private int Age
        //{
        //    get { return age; }
        //    set {  age = value;}
        //}
        //public int age { get; set; }
        

        #region Code snippets for property
        // Propfull : is a code snippet for [ full prperty]

        // provate string address;

        ///private String address
        ///{
        ///    get { return address; }
        ///    set { address = value}
        ///}

        // prop     : is  a code snippet fpr [ full property]
        // public string address {get; set;}

        #endregion

#endregion

        #region Constructors
        //public Employee (int id, string name, int salary)
        //{
        //    this.id = id;
        //    this.name =ValiddateName(name);
        //    this.salary = ValiddateSalary(salary);
        //}

        #endregion

        #region Methods
        //public override string ToString()
        //{
        //    return $"id = {this.id} \n Name = {this.name} \n salary = {this.salary:c}";
        //}

        //private string? ValiddateName(string? name)
        //{
        //    return name  is null ? null : name.Length <= 10 ? name : name.Substring(0, 10);
        //}

        //private decimal? ValiddateSalary(string? Salary)
        //{
        //    return Salary = salary >= 5000 ? salary : 5000;

        //}
        #endregion

    }
}
