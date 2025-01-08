using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_04.Built_in_InterFace
{
    internal class Employee : ICloneable, IComparable
    {
        // +ve : this.Salary > obj.Salary
        // -ve : this.Salary < obj.Salary
        // 0   : this.Salary = obj.Salary
        int IComparable.CompareTo(object? obj)
        {
            Employee Other = (Employee?) obj; // Explicit Casting

            return - this.Salary.CompareTo(Other?.Salary);  // (-) Make desc sorting
                                                            // UNpair Casting
            ///if (Other != null)
            ///    return 1;
            ///if(this.Salary > Other.Salary)
            ///    return 1;
            ///else if(this.Salary < Other.Salary)
            ///    return -1;
            ///return 0;
        }
    

    public int Id {  get; set; }

        public string? Name { get; set; }

        public decimal Salary { get; set; }

        public Department? department { get; set; }

        public object Clone()
        {
            return new Employee()
            {
                Id = this.Id,
                Name = this.Name,
                Salary = this.Salary,
                department = (Department) this.department?.Clone(),
            };

            

        }
        public override string ToString()
        {
            return $"Id = { Id} , Name = {Name} , Salary ={Salary:C}";
        }

        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }
    }
}
