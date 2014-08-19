/*Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. */
using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int mask = 1;
        bool isValueOne=(((n & (mask << position))>>position)==1);
        Console.WriteLine(isValueOne);
    }
}

