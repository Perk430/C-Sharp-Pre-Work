using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreWork_Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * numeralsString will stor the number we want to reverse
             * reverse will store the reversed number
             * numerals' only purpose is to check if the input is actually a number before trying to reverse it
             * inputIsNumber will make sure that the program keeps asking for a number until it gets one
             */

            string numeralsString = "", reverse = "";
            long numerals;
            bool inputlsNumber = false;

            Console.WriteLine("Welcome to the Number Reverse");

            // using a while loop to let the user enter their input up to 10 numbers while (inputIsNumber)
            { 
            Console.Write("Please input a number (max 10 digits):\t");
            numeralsString = Console.ReadLine();

            // Parsing the string to see if it's actually a number
            if (long.TryParse(numeralsString, out numerals)) {
                if (numeralsString.Length <= 10) {
                    inputlsNumber = true;
                    Console.WriteLine("You entered the number {0}", numerals);
                }
                else
                {
                    Console.Write("Sorry, that number is too large.  Remember, the max is 10 digits...\n\n");
                }
            }
            else
            {
                Console.WriteLine("Sorry, but that is not a number. Please try again...\n\n");
            }
        }
        /*
         * We have our number, now let's reverse it!
         * normally, people use for loops to count up to a certain point
         * but since we're going backwards, I thought it would be a good idea to count down instead
         * to pull characters starting from the end of the string
         */
        int i, len = numeralsString.Length;
        for (int = len; i > 0; i--) {
            // not forgetting to subtract one to get the right character
            reverse += numeralsString[int - 1];
        }

    //Ta-Dah!  Our number is reversed
    Console.WriteLine("Your number in reverse is {0}", reverse);

            // Our work here is done
            Console.Write("Press any key to close...");
        }
    }
}
