using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopsTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * One of the loop types is While Loop
             * 
             * While Loop syntax:
             * 
             * while (condition)
             * {
             *      CODE BLOCK
             * }
             * 
             * The condition that must be satisfied, in other words, the condition must be true, for the while loop to be executed. 
             */

            // Example 1

            int number = 0;
            bool is_converted = false; // The variable 'is_converted' must be assigned as false, otherwise, the expression 'while(!is_converted)' will evaluate to false, and the while loop will not be executed.

            while (!is_converted) // !is_converted = true. While loop could be executed.
            {
                Console.WriteLine("Enter a number");
                is_converted = Int32.TryParse(Console.ReadLine(), out number); // If the user enters an integer as input, 'is_converted' will be set to true. After receiving the input, the value of '!is_converted' will be false, which will stop the execution. 
                if (!is_converted) // If user enters incorrect types of input, is_converted will be set to false. In the context, if block will be executed.
                {
                    Console.WriteLine("Please enter a number, do not enter any other types");
                }
            }

            Console.WriteLine("Number = " +number);

            Console.WriteLine("------------------------------------------------------------------------------");

            // Example 2

            /// The code is used to detect how many digit is in number that user enters.

            // Method 1:

            Console.WriteLine("Enter a number");
            int number2;
            Int32.TryParse(Console.ReadLine(), out number2);

            int i = 10;
            bool digit = true; // to initialize, digit is true
            while (digit) 
            {
                int remainder = number2 % i; 
                // for example, a user enters 1234 as an input
                // 1234 % 10 = 4
                // 1234 % 100 = 34
                // 1234 % 1000 = 234
                // 1234 % 10000 = 1234
                Console.WriteLine("remainder = " + remainder + " i = " + i);

                if (number2 / i == 0)
                    // 1234 / 10000 = 0
                {
                    digit = false; // After the calculation output becomes 0, the variable 'digit' will be assigned to false, and condition for the while loop will not be satisfied, causing the loop to terminate.
                    Console.WriteLine("The limit exceeded");

                }
                i *= 10;

            }
            Console.WriteLine("The last remainder is equal to input, you can count how many digit exists in the input\n\n\n");

            // Method 2:

            Console.WriteLine("Enter a number");
            int number3;
            Int32.TryParse(Console.ReadLine(), out number3);

            while(number3>0)
            {
                int rm = number3 % 10; // remainder
                Console.WriteLine("The last digit = " + rm);
                number3 /= 10; // to erase last digit of the input

            }
            Console.WriteLine("You can count how many the last digits exist in the input to find number of digits in the input");


        }


    }
}

