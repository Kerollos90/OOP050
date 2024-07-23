using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    internal class Duration
    {

        private int hours;
        private int minutes;
        private int seconds;
        public int Seconds
        {
            get { return seconds; }
            set
            {
                seconds = value;
                while (seconds >= 60)
                {
                    minutes += seconds / 60;
                    seconds %= 60;
                }
                while (minutes >= 60)
                {
                    hours += minutes / 60;
                    minutes %= 60;
                }
            }
        }
        public int Minutes
        {
            get { return minutes; }

            set
            {
                minutes = value;
                while (minutes >= 60)
                {
                    hours += minutes / 60;
                    minutes %= 60;
                }
            }
        }

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        //Constructors
        public Duration()
        {
            hours = minutes = seconds = 0;
        }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int seconds)
        {
            Seconds = seconds;
        }
      
        public override string ToString()
        {
            if (hours != 0)
                return $"Hours = {hours} , Minutes = {minutes} , Seconds = {seconds}";
            else if (minutes != 0)
                return $"Minutes = {minutes} , Seconds = {seconds}";
            else
                return $"Seconds = {seconds}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is not null)
            {
                Duration D = (Duration)obj;
                return (hours == D.hours && minutes == D.minutes && seconds == D.seconds);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ hours + minutes + seconds;
        }

       
        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration()
            {
                Hours = left?.hours ?? 0 + right?.hours ?? 0,
                Minutes = left?.minutes ?? 0 + right?.minutes ?? 0,
                Seconds = left?.seconds ?? 0 + right?.seconds ?? 0,
            };
        }
        
        public static Duration operator -(Duration left, Duration right)
        {
            if (left > right)
            {
                int totalSeconds = ((left.hours * 3600 + left.minutes * 60 + left.seconds)) - ((right.hours * 3600 + right.minutes * 60 + right.seconds));
                return new Duration(totalSeconds);
            }
            return new Duration();
        }


       
        public static Duration operator +(Duration left, int right)
        {
            return new Duration(right) + left;
        }
        
        public static Duration operator +(int left, Duration right)
        {
            return new Duration(left) + right;
        }
        
        public static Duration operator ++(Duration D1)
        {
            return new Duration()
            {
                Hours = D1?.hours ?? 0,
                Minutes = (D1?.minutes ?? 0) + 1,
                Seconds = D1?.seconds ?? 0,
            };
        }
        
        public static Duration operator --(Duration D1)
        {

            if (D1.minutes == 0 && D1.Hours != 0)
            {
                return new Duration()
                {
                    Hours = (D1?.hours ?? 0) - 1,
                    Minutes = 59,
                    Seconds = D1?.seconds ?? 0,
                };
            }
            return new Duration()
            {
                Hours = D1?.hours ?? 0,
                Minutes = (D1?.minutes ?? 0) - 1,
                Seconds = D1?.seconds ?? 0,
            };
        }
       
        public static bool operator >(Duration left, Duration right)
        {
            return (left.hours > right.hours || (left.hours == right.hours && left.minutes > right.minutes) ||
                    (left.hours == right.hours && left.minutes == right.minutes && left.seconds > right.seconds));
        }
       
        public static bool operator <(Duration left, Duration right)
        {
            return (left.hours < right.hours || (left.hours == right.hours && left.minutes < right.minutes) ||
                    (left.hours == right.hours && left.minutes == right.minutes && left.seconds < right.seconds));
        }
      
        public static bool operator <=(Duration left, Duration right)
        {
            return (left.hours * 3600 + left.minutes * 60 + left.seconds) <= (right.hours * 3600 + right.minutes * 60 + right.seconds);
        }
      
        public static bool operator >=(Duration left, Duration right)
        {
            return (left.hours * 3600 + left.minutes * 60 + left.seconds) >= (right.hours * 3600 + right.minutes * 60 + right.seconds);
        }
       
        public static bool operator true(Duration D)
        {
            return (D.hours != 0 || D.minutes != 0 || D.seconds != 0);
        }
        
        public static bool operator false(Duration D)
        {
            return (D.hours == 0 || D.minutes == 0 || D.seconds == 0);
        }
      



    }
}
