using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assginment_03
{
    internal class Duration
    {
        #region Property
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        #endregion

        #region Constructors
      
        public Duration(int hours, int minutes, int seconds)
        {
          
            if (seconds >= 60)
            {
                minutes += seconds / 60;
                seconds %= 60;
            }

            if (minutes >= 60)
            {
                hours += minutes / 60;
                minutes %= 60;
            }

            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }

        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Duration other)
            {
                return Hours == other.Hours &&
                       Minutes == other.Minutes &&
                       Seconds == other.Seconds;
            }
            return false;
        }


        public override int GetHashCode()
        {
           
            return HashCode.Combine(Hours, Minutes, Seconds);
        }

        #endregion


        #region Method


        public void DisplayDuration()
        {
            Console.WriteLine($"Duration: {Hours:D2}:{Minutes:D2}:{Seconds:D2}");
        }

        #endregion

    

 


      
   
    }
}
