using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_04.Built_in_InterFace
{
    internal class Employee :ICloneable
    {
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
