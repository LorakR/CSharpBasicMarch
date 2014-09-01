/*Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.*/

using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        //use array of type string
        //.Split(' ') saves the value written before the first space of the entered string at the cell with index[0], the value before the second space at the cell with index[1] and so on..
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

