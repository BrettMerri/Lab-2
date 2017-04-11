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
            Console.Write("Please enter your first name: ");
            string name = Console.ReadLine();

            while (true) {
                Console.Clear();
                Console.WriteLine("Hello, " + name + "!");
                Console.Write("Enter a number between 1 and 100: ");

                int intInput;
                string input = Console.ReadLine();

                if (!int.TryParse(input, out intInput))
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }

                if (intInput % 2 == 1)
                {
                    Console.WriteLine(input + " and Odd");
                }
                else if (intInput % 2 == 0)
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
                Console.Write("Continue? (y/n): ");
                string continueInput = Console.ReadLine().ToLower();
            if (continueInput != "y")
                {
                    return;
                }
            }
        }
    }
}
