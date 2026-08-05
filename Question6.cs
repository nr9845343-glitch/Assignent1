using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Question6
    {

        static void Main6()
        {
            Console.Write("Enter N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Even Numbers:");

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Odd Numbers:");

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                    Console.Write(i + " ");
            }
        }
    }
}
