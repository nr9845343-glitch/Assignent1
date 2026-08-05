using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program1
    {
        static void Main1(string[] args)
        {
            
            
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Roll Number: ");
                int roll = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Marks: ");
                double marks = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n----- Student Details -----");
                Console.WriteLine("Name : " + name);
                Console.WriteLine("Roll Number : " + roll);
                Console.WriteLine("Marks : " + marks);
            }
        }
    }

