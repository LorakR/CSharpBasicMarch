/*Write a program that finds the biggest of three numbers. */

using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (c > Math.Max(a, b))
        {
            Console.WriteLine(c);
        }
        else
        {
            Console.WriteLine(Math.Max(a,b));
        }
    }
}

