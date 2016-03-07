using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AgeCalculate();
            Close();
        }
        public static void AgeCalculate()
        {
            Console.Write("Please enter your birthdate (YYYY/MM/DD): ");
            string input = Console.ReadLine();
            var dateOfBirth = DateTime.Parse(input);
            TimeSpan duration = DateTime.Now.Subtract(DateTime.Parse(input));

            /* Assumptions being made here: A year being 365.25 days, a week being 7 days, hence those numbers. */

            int iDays = duration.Days; // It works!  Credit to Mike F for the .Days bit.
            int iYear = (int)(iDays / 365.25); // Lazy mode for the math, sorry.
            iDays -= (int)(iYear * 365.25);
            int iWeek = iDays / 7;
            iDays -= (iWeek * 7);
            Console.WriteLine("You are {0} years, {1} weeks, {2} days old!", iYear, iWeek, iDays);
        }
        public static void Close()
        {
            Console.ReadKey();
            Console.WriteLine("Would you like to run another calculation? (y/n)"); // for good practice
            string userValue = Console.ReadLine();
            userValue = userValue.ToLower();
            if (userValue == "y")
            {
                Environment.Exit(0);
            }
            if (userValue == "n")
            {
                AgeCalculate();
            }
            else
            {
                Console.WriteLine("Please enter a valid answer.");
            }
        }
    }
}

