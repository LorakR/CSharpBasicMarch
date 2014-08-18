/*Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.*/
using System;

class DivideBy7and5
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isDivisible = (n % 7 == 0 && n % 5 == 0) && (n >= 1);
        Console.WriteLine(isDivisible);
    }
}

