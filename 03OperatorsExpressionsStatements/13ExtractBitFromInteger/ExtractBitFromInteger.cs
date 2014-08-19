/*Write an expression that extracts from given integer n the value of given bit at index p.*/

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int mask = 1;
        int bitAtWantedPosition = ((n & (1 << position)) >> position);
        Console.WriteLine(bitAtWantedPosition);
    }
}

