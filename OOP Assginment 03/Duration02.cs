using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assginment_03
{
    internal class Duration02
    {

        #region Properties
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        #endregion

        #region Constructors
        public Duration02(int hours, int minutes, int seconds)
        {
            NormalizeDuration(hours, minutes, seconds);
        }

        public Duration02(int totalSeconds)
        {
            NormalizeDuration(0, 0, totalSeconds);
        }

      
        public Duration02()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }

    
        private void NormalizeDuration(int hours, int minutes, int seconds)
        {
            minutes += seconds / 60;
            seconds %= 60;

            hours += minutes / 60;
            minutes %= 60;

            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

 
        public static Duration02 operator +(Duration02 d1, Duration02 d2)
        {
            return new Duration02(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }

        public static Duration02 operator +(Duration02 d1, int seconds)
        {
            return new Duration02(d1.Hours, d1.Minutes, d1.Seconds + seconds);
        }

        public static Duration02 operator +(int seconds, Duration02 d2)
        {
            return new Duration02(d2.Hours, d2.Minutes, d2.Seconds + seconds);
        }


        public static Duration02 operator -(Duration02 d1, Duration02 d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return new Duration02(Math.Max(0, totalSeconds1 - totalSeconds2));
        }
        public static Duration02 operator ++(Duration02 d)
        {
            return new Duration02(d.Hours, d.Minutes + 1, d.Seconds);
        }

        public static Duration02 operator --(Duration02 d)
        {
            return new Duration02(d.Hours, d.Minutes - 1, d.Seconds);
        }

        
        public static bool operator >(Duration02 d1, Duration02 d2)
        {
            return d1.TotalSeconds() > d2.TotalSeconds();
        }

        public static bool operator <(Duration02 d1, Duration02 d2)
        {
            return d1.TotalSeconds() < d2.TotalSeconds();
        }

        public static bool operator >=(Duration02 d1, Duration02 d2)
        {
            return d1.TotalSeconds() >= d2.TotalSeconds();
        }

        public static bool operator <=(Duration02 d1, Duration02 d2)
        {
            return d1.TotalSeconds() <= d2.TotalSeconds();
        }

        
        public static explicit operator DateTime(Duration02 d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }

       
        public static implicit operator bool(Duration02 d)
        {
            return d.TotalSeconds() > 0;
        }

        private int TotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }
        #endregion

        #region Method

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
