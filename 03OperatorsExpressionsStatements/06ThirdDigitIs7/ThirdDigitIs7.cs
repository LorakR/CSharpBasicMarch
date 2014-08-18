/*Write an expression that checks for given integer if its third digit from right-to-left is 7*/

using System;

class ThirdDigitIs7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        // n/100 takes off the first two digits of the number from right-to-left
        // %10 checks whether the third digit is seven
        bool isSeven = (n / 100) % 10 == 7;
        Console.WriteLine(isSeven);
    }
}

