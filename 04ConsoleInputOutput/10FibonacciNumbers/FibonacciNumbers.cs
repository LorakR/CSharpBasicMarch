/*Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….*/

using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int c;
        if (n == 1)
        {
            Console.WriteLine(a);
        }
        else if (n == 2)
        {
            Console.WriteLine("{0} {1}",a,b);
        }
        else
        {
            Console.Write("{0} {1} ", a, b);
            for (int i = 1; i <= n - 2; i++)
            {
                c = a;
                a = b;
                b = c + a;
                Console.Write("{0} ",b);
            }
        }
    }
}

