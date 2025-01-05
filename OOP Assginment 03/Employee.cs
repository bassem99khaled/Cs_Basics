using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assginment_03
{
    internal class Employee
    {
        public int employee { get; set; }
        
        public virtual void Work()
        {
            Console.WriteLine("Employee is working.");
        }
    }
    
    public class Manager : Employee
    {
       public String manger {  get; set; }
        public Manager(string manger) : base(employee)
        {
            this.manger = manger;
        }
        
        public override void Work()
        {
            base.Work(); 
            Console.WriteLine("Manager is managing.");
        }
        
    }
}
