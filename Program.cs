using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine();
            Console.Write("Number 1 : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 2 : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The Summation of {0} + {1} = {2}", num1, num2, num1 + num2);
        }
    }
}