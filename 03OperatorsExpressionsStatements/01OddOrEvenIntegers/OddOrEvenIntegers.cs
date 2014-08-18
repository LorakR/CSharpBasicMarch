/*Write an expression that checks if given integer is odd or even.*/

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //In case the condition is fulfilled the value of the variable isOdd will be true. Otherwise the value will be false.
        bool isOdd = n % 2 != 0;
        Console.WriteLine(isOdd);
    }
}

