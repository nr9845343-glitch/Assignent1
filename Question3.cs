using System;

class Program3
{
    static void Main3()
    {
        Console.Write("Enter a Number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
            Console.WriteLine("Positive");
        else if (num < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Zero");
    }
}
