/*Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned.*/

using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        //convert to hex value
        string aHexdemical = a.ToString("X");
        //convert to binary format
        string aBinary = Convert.ToString(a, 2);
        //{index[,alignment][:formatString]} 
        //if the number after the comma is positive the argument will be right-aligned
        //if it's negative --> left-aligned
        //"#" is used to say that the numner at this position will not be printed if it is zero
        Console.Write("|{0,-10}",aHexdemical);
        //the binary should be padded with leading zeros from the left
        Console.Write("|{0}",(aBinary).PadLeft(10,'0'));
        Console.Write("|{0,10:0.##}",b);
        Console.WriteLine("|{0,-10:0.###}|",c);
    }
}

