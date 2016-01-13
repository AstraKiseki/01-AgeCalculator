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
            Console.Write("Please enter your birthdate (YYYY/MM/DD): ");  // starting point for brain.  Need to turn DOB into string?)
            string input = Console.ReadLine();
            var dateOfBirth = DateTime.Parse(input);
            TimeSpan duration = DateTime.Now.Subtract(DateTime.Parse(input));

            /* Okay, assumptions being made here: A year being 365.25 days, a week being 7 days, hence those numbers.
            ANYWAY YAY
    */

            int iDays = duration.Days; // It works!  Credit to Mike F for the .Days bit.
            int iYear = (int)(iDays / 365.25); // Lazy mode for the math, sorry.
            iDays -= (int)(iYear * 365.25);
            int iWeek = (int)(iDays / 7); // HOW THE FUCK DO I DO THIIIIIIS.  I'm going to borrow.  Surprise, I didn't borrow much.
            iDays -= (int)(iWeek * 7);
            Console.WriteLine("You are {0} years, {1} weeks, {2} days old!", iYear, iWeek, iDays);

            Console.ReadKey();
            Console.WriteLine("Exit? (y/n)"); // for good practice
            string userValue = Console.ReadLine();

            if (userValue == "y")
            {
                Environment.Exit(0);
            }

            if (userValue == "n")
            {
                
            }
        }
    }
}
