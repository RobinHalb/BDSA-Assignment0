using System;

namespace BDSA_Assignment0
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 'exit' to end program");
            var run = true;
            while (run) {
                Console.Write("Enter year: ");
                var input = Console.ReadLine();
                int year;
                var parsed = int.TryParse(input, out year);
                if (parsed) {
                    if (IsLeapYear(year)) Console.WriteLine("yay");
                    else Console.WriteLine("nay");
                }
                else if (input == "exit") run = false; 
                else Console.WriteLine("Please enter an integer, or write 'exit' to end program");
            }
        }

        public static bool IsLeapYear(int year) {
            if(year % 4 != 0) return false;
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            return true;
        }
    }
}
