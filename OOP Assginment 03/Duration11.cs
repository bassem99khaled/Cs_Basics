using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assginment_03
{
    internal class Duration11
    {
        
            #region Properties
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }

#endregion

            #region Constructor
            public Duration11(int hours, int minutes, int seconds)
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

            public Duration11()
            {
                Hours = 0;
                Minutes = 0;
                Seconds = 0;
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
