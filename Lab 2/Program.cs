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
            while (true) {
                Console.Write("Enter a number between 1 and 100: ");
                int input = int.Parse(Console.ReadLine());

                if (input % 2 == 1)
                {
                    Console.WriteLine(input + " and Odd");
                }
                else if (input % 2 == 0)
                {
                    if (input <= 25)
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                    else if (input <= 60)
                    {
                        Console.WriteLine("Even");
                    }
                    else if (input > 60)
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
                Console.Clear();
            }
        }
    }
}
