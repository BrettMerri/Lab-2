using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name: "); //Prompt for first name
            string name = Console.ReadLine();

            while (true) {
                Console.Clear();
                Console.WriteLine("Hello, " + name + "!");
                Console.Write("Enter a number between 1 and 100: ");

                int intInput;
                string input = Console.ReadLine();

                if (!int.TryParse(input, out intInput)) //Validation if input is an integer
                {
                    Console.WriteLine("Input not an integer!"); //If statement will run if input is not an integer
                    return;
                }
                if (intInput < 1 || intInput > 100) //Validation if input is between 1 and 100
                {
                    Console.WriteLine("Input is in an invalid range!");
                    return;
                }

                if (intInput % 2 == 1) //Odd numbers
                {
                    Console.WriteLine(input + " and Odd");
                }
                else if (intInput % 2 == 0) //Even numbers
                {
                    if (intInput <= 25)
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                    else if (intInput <= 60)
                    {
                        Console.WriteLine("Even");
                    }
                    else if (intInput > 60)
                    {
                        Console.WriteLine(input + " and Even");
                    }
                }

                Console.Write("Continue? (y/n): "); //Prompt user to continue

                string continueInput = Console.ReadLine().ToLower();

            if (continueInput == "y")
                {
                    continue;
                }
            else if (continueInput == "n")
                {
                    return;
                }
            else
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
            }
        }
    }
}
