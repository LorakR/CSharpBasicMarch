/*Write a program that prints the first 10 members of the sequence: 2,-3,4,-5,6,-7 ...*/

using System;

class PrintASequence
{
    static void Main()
    {
        for (int i = 2; i < 12; i++)
        {
            //if the number is odd print it as a negative
            if (i % 2 != 0)
            {
                /*After the last member of the sequence: print without comma and set the cursor to new line 
                 for better visualisation*/
                if (i == 11)
                {
                    Console.Write("-" + (i) + "\n");
                }
                else
                {
                    Console.Write("-" + (i) + ", ");
                }
            }
            else
            {
                Console.Write(i + ", ");
            }
        }
    }
}
