using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Question5
    {
        static void Main5()
        {
            Console.Write("Enter First Number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result = " + (a + b));
                    break;

                case 2:
                    Console.WriteLine("Result = " + (a - b));
                    break;

                case 3:
                    Console.WriteLine("Result = " + (a * b));
                    break;

                case 4:
                    if (b != 0)
                        Console.WriteLine("Result = " + (a / b));
                    else
                        Console.WriteLine("Division by zero is not possible.");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }
    }
}
