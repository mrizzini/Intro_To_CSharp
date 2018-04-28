using System;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
           // create an if decision block
            // use this if block to check for an even number


        //     // Request user input with ReadLine()
        //     Console.WriteLine("Please enter an integer value and press Enter.");

        //     // Assign the entered value to the variable input
        //     // convert input to integer before using
        //     int input = Int32.Parse( Console.ReadLine());

        //     // Check to see if the number is even.
        //     // Here we use the simple task of checking for a remainder when dividing by 2
        //     // The (%) or modulus operator returns the remainder of integer devision.
        //     // If the remainder is 0, then the value is able to be divided by 2 with
        //     // no remainder, which means it is an even number.
        //     if(input % 2 == 0)
        //     {
        //         Console.WriteLine("The entered number was an even number.");
        //     }
        //     else  // the remainder was not 0 so the value entere is an odd number.
        //     {
        //         Console.WriteLine("The entered number was not an even number.");
        //     }
        // }


     // Create a switch block

            // Console.WriteLine("Coffee sizes: 1=small 2=medium 3=large");
            // Console.Write("Please enter your selection: ");
            // string str = Console.ReadLine();
            // int cost = 0;

            // switch (str)
            // {
            //     case "1":
            //     case "small":
            //         cost += 25;
            //         break;
            //     case "2":
            //     case "medium":
            //         cost += 50;
            //         break;
            //     case "3":
            //     case "large":
            //         cost += 75;
            //         break;
            //     default:
            //         Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
            //         break;
            // }
            // if (cost != 0)
            // {
            //     Console.WriteLine("Please insert {0} cents.", cost);
            // }
            // Console.WriteLine("Thank you for your business.");


            // Create a simple for loop that displays the values of the counter
            // The WriteLine method here demonstrates the use of string interpolation in C#
            // as a way of outputting literal string values with variable values.
            // It is the recommended way to deal with this method of string output
            // for(int counter = 0; counter < 10; counter++)
            // {
            //     Console.WriteLine($"Counter is at: {counter}"); 
            // }

            // Create a while loop
            // We start with n = 1
            // The condition check for the while, tests if n is less than 6, if so, the loop body code executes
            // inside the loop, we output the value of n and then increment it by 1
            // Once n = 6, the loop stops
            // Pay attention to the output to see what the last value is to ensure you understand
            // how the evaluation of the condition is done and how the while loop executes
            // int n = 1;
            // while (n < 6)
            // {
            //     Console.WriteLine($"Current value of n is {n}");
            //     n++;
            // }

            bool test = true;
            // bool newLine;

            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    if (test)
                    {
                        Console.Write("X");
                        test = false;
                    }
                    else if (!test)
                    {
                        Console.Write("O");
                        test = true;
                    }
                    
                }
                Console.WriteLine();
                Console.WriteLine();
                if (test)
                {
                    test = false;
                }
                else
                {
                    test = true;
                }
                // test = false;
            }





        }

    }
}
