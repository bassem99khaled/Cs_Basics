using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_02.Association.Aggregation
{

    // Association Relationship {Aggregation} : Has A
    //                                        : Department Has A Employees?
    internal class Department
    {
        public int Code     { get; set; }
        public required string Name { get; set; }

        public List<Employee>? Employees { get; set; }


    }
}
