/*Write a program to print the numbers 1, 101 and 1001, each at a separate line.*/

using System;

class PrintNumbers
{
    static void Main()
    {
        //Common way
        Console.WriteLine("1");
        Console.WriteLine("101");
        Console.WriteLine("1001");

        //Empty line for better visualisation
        Console.WriteLine("");

        //With placeholder --> \n insert new line
        Console.WriteLine("{0}\n{1}\n{2}", 1, 101, 1001);
    }
}
