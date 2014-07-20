/*Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …*/

using System;

class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i < 1012; i++)
        {
            //After the last member of the sequence not to put comma and add new line after it for better visualisation
            if ((i % 2 != 0) && (i == 1011))
            {
                Console.Write("-{0}\n", i);
            }
            else if (i % 2 != 0)
            {
                Console.Write("-{0}, ", i);
            }
            else
            {
                Console.Write("{0}, ", i);
            }
        }
    }
}
