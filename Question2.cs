 using System;

class Program2
{
    static void Main2()
    {
        Console.Write("Enter First Number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sum = " + (a + b));
        Console.WriteLine("Difference = " + (a - b));
        Console.WriteLine("Product = " + (a * b));
        Console.WriteLine("Quotient = " + (a / b));
        Console.WriteLine("Remainder = " + (a % b));
    }
}
