using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Question7
    {
        static void Main7()
        {
            Console.Write("Enter Number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            long fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            Console.WriteLine("Factorial = " + fact);
        }
    }
}

