/*Write a program that reads 3 real numbers from the console and prints their sum.*/

using System;
//these two using directives allow us to change the culture of the current thread later
using System.Threading;
using System.Globalization;

class SumOfThreeNumbers
{
    static void Main()
    {
        //Number formats are different in different countries e.g the decimal separator can be "." or ","
        //To ensure that the decimal separator is "." - use the following code
        //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double sum = a + b + c;
        Console.WriteLine(sum);
    }
}

