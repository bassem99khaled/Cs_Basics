using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_02
{
    internal class HiringDate
    {
        #region  Properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        #endregion

        #region Constructor
        public HiringDate(int day, int month, int year)
        {
            
            Day = day;
            Month = month;
            Year = year;
        }
        #endregion

        #region  Method 


       
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

        #endregion



    }
}
