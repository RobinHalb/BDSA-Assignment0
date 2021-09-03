using System;

namespace BDSA_Assignment0
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public bool IsLeapYear(int year) {
            if(year % 4 != 0) return false;
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            return true;
        }
    }
}
