using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_04.Built_in_InterFace
{
    internal class EmployeeComparer : IComparable


    {

        public int Compare(object? x , object? y)
        {
            Employee? employeex = (Employee?)x;
            Employee employeey = (Employee?)y;
        
            return employeex?.Id.CompareTo(employeey?.Id) ?? (employeey is null ? 0 : -1);
        
        }

        int IComparable.CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
