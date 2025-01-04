using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Second_Project
{
    internal class Duration
    {
        #region Attribiutes
        private int hours;
        private int minutes;
        private int seconds;

        #endregion

        #region Methods
        public override string ToString()
        {
            if (hours > 0)
                return $"Hours:{hours} & Minutes: {minutes} & Seconds: {seconds}";
            else
                return $"Minutes: {minutes} & Seconds: {seconds}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Duration other)
                return hours == other.hours && minutes == other.minutes && seconds == other.seconds;
            return false;
        }

        public override int GetHashCode()
        {
            return hours.GetHashCode() ^
                   minutes.GetHashCode() ^
                   seconds.GetHashCode();
        }

        private void Normalize()
        {
            minutes += seconds / 60;
            seconds %= 60;
            hours += minutes / 60;
            minutes %= 60;
        }
        #endregion

        #region Constructors
        public Duration(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
            Normalize();
        }

        public Duration(int totalseconds)
        {
            seconds = totalseconds;
            Normalize();
        }
        #endregion

        #region Operators Overloading
        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration(left.hours + right.hours, left.minutes + right.minutes, left.seconds + right.seconds);
        }

        public static Duration operator +(Duration duration, int seconds)
        {
            return new Duration(duration.hours, duration.minutes, duration.seconds + seconds);
        }

        public static Duration operator +(int seconds, Duration duration)
        {
            return new Duration(duration.hours, duration.minutes, duration.seconds + seconds);
        }

        public static Duration operator -(Duration left, Duration right)
        {
            return new Duration(left.hours - right.hours, left.minutes - right.minutes, left.seconds - right.seconds);
        }

        public static Duration operator ++(Duration duration)
        {
            return new Duration(duration.hours, duration.minutes + 1, duration.seconds);
        }
        public static Duration operator --(Duration duration)
        {
            return new Duration(duration.hours, duration.minutes - 1, duration.seconds);
        }

        public static bool operator >(Duration left, Duration right)
        {
            return (left.hours + left.minutes + left.seconds > right.hours + right.minutes + right.seconds);
        }
        public static bool operator <(Duration left, Duration right)
        {
            return (left.hours + left.minutes + left.seconds) < (right.hours + right.minutes + right.seconds);
        }

        public static bool operator >=(Duration left, Duration right)
        {
            return (left.hours + left.minutes + left.seconds >= right.hours + right.minutes + right.seconds);
        }
        public static bool operator <=(Duration left, Duration right)
        {
            return (left.hours + left.minutes + left.seconds) <= (right.hours + right.minutes + right.seconds);
        }

        public static explicit operator DateTime(Duration duration)
        {
            return new DateTime(2025, 1, 4, duration.hours, duration.minutes, duration.seconds);
        }
        #endregion
    }
}