/*We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.*/

using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());
        int mask=1;
        int result = 0;
        if (value == 1)
        {
            result = number | (mask << position);
        }
        else if (value == 0)
        {
            result = number & (~(mask << position));
        }
        Console.WriteLine(result);
    }
}

