/*Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.*/

using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        string[] fiveNumbers = Console.ReadLine().Split(' ');
        double a = double.Parse(fiveNumbers[0]);
        double b = double.Parse(fiveNumbers[1]);
        double c = double.Parse(fiveNumbers[2]);
        double d = double.Parse(fiveNumbers[3]);
        double e = double.Parse(fiveNumbers[4]);
        double sum = a + b + c + d + e;
        Console.WriteLine("The sum of the entered numbers is: {0}",sum);
    }
}

