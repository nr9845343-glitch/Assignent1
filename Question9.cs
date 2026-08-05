using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Question9
    {
        static void Main9()
        {
            Console.Write("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int original = num;
            int reverse = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reverse = reverse * 10 + digit;
                num /= 10;
            }

            if (original == reverse)
                Console.WriteLine("Palindrome Number");
            else
                Console.WriteLine("Not a Palindrome Number");
        }
    }
}
