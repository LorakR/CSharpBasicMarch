/*Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.*/

using System;

class ComparingFloats
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        const double eps = 0.000001;
        if (Math.Abs(a - b) >= eps)
        {
            Console.WriteLine("false");
        }
        else
        {
           Console.WriteLine("true");
        }
    }
}

