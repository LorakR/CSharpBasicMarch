/*Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.*/

using System;

class BitsExchange
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        //use 7 as a mask since it's binary representation is 00000111 and I need to save the value of three consecutive bits
        uint mask = 7;
        //preserves only the value of bits number 3,4,5 and puts them at the right end of the number
        uint firstBits = ((number & (mask << 3)) >> 3);
        //preserves only the value of bits number 24,25,26 and puts them at the right end of the number 
        uint secondBits = ((number & (mask << 24)) >> 24);
        //nullify only the value of bits number 3,4,5
        number = number & ~(mask << 3);
        //then nullify also the value of bits number 24,25,26
        number = number & ~(mask << 24);
        //put the value of bits number 3,4,5 at position 24,25,26 and preserve the value of the other bits
        number = number | (firstBits << 24);
        //put the value of bits number 24,25,26 at position 3,4,5 and preserve the value of the other bits
        number = number | (secondBits << 3);
        Console.WriteLine(number);
    }
}

