/*Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. The first and the second sequence of bits may not overlap. */

using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        //find whether p or q index is bigger
        //then add to the bigger index k-1 and check if the result index is more than 31
        //we check with the number 31 because in the task is said that we will work with 32-bit integer number
        //31 instead of 32 because bits are counted from 0.. not from 1
        if (Math.Max(p, q) + k - 1 > 31)
        {
            Console.WriteLine("out of range");
        }
        else if (Math.Min(p, q) + k - 1 >= Math.Max(p, q))
        {
            Console.WriteLine("overlapping");
        }
        else
        {
            for (int i = p; i <= p + k - 1; i++)
            {
                uint mask = 1;
                //preserve only the value of the bit at position p and puts it at the right end of the number
                uint bitP = (n & (mask << i)) >> i;
                //preserve only the value of the bit at position q and puts it at the right end of the number
                uint bitQ = (n & (mask << q)) >> q;
                //nullify the bit at postion p
                n = n & ~(mask << i);
                //nullify the bit at position q
                n = n & ~(mask << q);
                //exchange the value of the bits at position p and q 
                n = n | (bitP << q);
                n = n | (bitQ << i);
                q++;
            }
            Console.WriteLine(n);
        }
        
    }
}

