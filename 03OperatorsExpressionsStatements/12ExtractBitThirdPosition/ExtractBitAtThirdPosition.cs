/*Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0.*/

using System;

class ExtractBitAtThirdPosition
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        //00000001
        uint bitMask = 1;
        //save only the value of the bit at third position and nullifying all the others
        //then put the third bit at first position
        uint thirdBit = ((n & (bitMask << 3))>>3);
        Console.WriteLine(thirdBit);
    }
}

