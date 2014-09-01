/*Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.*/

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("How much numbers would you like to enter: ");
        int n = int.Parse(Console.ReadLine());
        float sum = 0;
        float currentNumber = 0;
        for (int i = 1; i <= n; i++)
        {
            currentNumber = float.Parse(Console.ReadLine());
            sum = sum + currentNumber;
        }
        Console.WriteLine("The sum of the entered numbers is: {0}",sum);
    }
}

