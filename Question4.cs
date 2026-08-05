using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Question4
    {
        static void Main4()
        {
            Console.Write("Enter Marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 91 && marks <= 100)
                Console.WriteLine("Grade: O");
            else if (marks >= 81)
                Console.WriteLine("Grade: A+");
            else if (marks >= 71)
                Console.WriteLine("Grade: A");
            else if (marks >= 61)
                Console.WriteLine("Grade: B+");
            else if (marks >= 51)
                Console.WriteLine("Grade: B");
            else
                Console.WriteLine("Fail");
        }
    }
}
