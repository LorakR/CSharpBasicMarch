/*You are given two numbers: diff and sum. Using the digits from 1 to 7 generate all 9-digit numbers in format abcdefghi, such that their sub-numbers abc, def and ghi have a difference diff (ghi-def = def-abc = diff), their sum of digits is sum and abc ≤ def ≤ ghi. Numbers holding these properties are also called “nine-digit magic numbers”. Print these numbers in increasing order.*/

using System;

class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool isFound = false;
        int abc = 0;
        int def = 0;
        int ghi = 0;
        for (int a = 1; a <= 7; a++)
        {
            for (int b = 1; b <= 7; b++)
            {
                for (int c = 1; c <= 7; c++)
                {
                    abc = a * 100 + b * 10 + c;
                    for (int d = 1; d <= 7; d++)
                    {
                        for (int e = 1; e <= 7; e++)
                        {
                            for (int f = 1; f <= 7; f++)
                            {
                                def = d * 100 + e * 10 + f;
                                for (int g = 1; g <= 7; g++)
                                {
                                    for (int h = 1; h <= 7; h++)
                                    {
                                        for (int i = 1; i <= 7; i++)
                                        {
                                            ghi = g * 100 + h * 10 + i;
                                            if ((ghi - def == diff) && (def - abc == diff))
                                            {
                                                if (a + b + c + d + e + f + g + h + i == sum)
                                                {
                                                    if ((abc <= def) && (def <= ghi))
                                                    {
                                                        isFound = true;
                                                        Console.WriteLine("{0}{1}{2}", abc, def, ghi);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (isFound == false)
        {
            Console.WriteLine("No"); 
        }
    }
}

