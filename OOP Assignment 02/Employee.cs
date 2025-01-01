using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_02
{
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    internal class Employee 

    {

        #region propeties
        public int ID { get; set; }
            public string Name { get; set; }
            private char gender;
            public char Gender
            {
                get { return gender; }
                set
                {
                    if (value == 'M' || value == 'F')
                        gender = value;

                }
            }
            public SecurityLevel Security { get; set; }
            public decimal Salary { get; set; }
            public DateTime HireDate { get; set; }

        public static int BoxingCount { get;  set; } 
        public static int UnboxingCount { get;  set; } 


        #endregion

        #region Constructor

        public Employee(int id, string name, char gender, SecurityLevel security, decimal salary, DateTime hireDate)
            {
                ID = id;
                Name = name;
                Gender = gender; 
                Security = security;
                Salary = salary;
                HireDate = hireDate;
            }

        public int CompareTo(Employee compare)
        {
            return HireDate.CompareTo(compare.HireDate);
        }


        #endregion

        #region Method
        public override string ToString()
            {
                return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Security Level: {Security}, Salary: {Salary}, Hire Date: {HireDate:yyyy-MM-dd}";
            }
        #endregion
    }
}
