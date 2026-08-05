using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Question8
    {
        static void Main8()
        {
            Console.Write("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool prime = true;

            if (num <= 1)
                prime = false;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not Prime");
        }
    }
}

