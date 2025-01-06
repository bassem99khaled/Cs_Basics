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
        //
        #endregion

        #region Constructors
        public Duration(int hours, int minutes, int seconds)
        {
            NormalizeDuration(hours, minutes, seconds);
        }

        
        public Duration(int totalSeconds)
        {
            NormalizeDuration(0, 0, totalSeconds);
        }

      
        public Duration()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }

        #endregion

        #region Method
        public void NormalizeDuration(int hours, int minutes, int seconds)
        {
            minutes += seconds / 60;
            seconds %= 60;

            hours += minutes / 60;
            minutes %= 60;

            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

   
        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            else
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
        }
    

    #endregion


}
}
