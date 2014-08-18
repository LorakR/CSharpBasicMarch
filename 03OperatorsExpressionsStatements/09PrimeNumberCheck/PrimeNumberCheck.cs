/*Write an expression that checks if given integer number n (n ≤ 100) is prime (A number is prime if it is bigger than 1 and is divisible without remainder only to itself and 1). */

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (n > 1)
        {
            //if the number n divisible by a number different from 1 or itself --> the number is NOT prime
            //use "break" to stop the loop from unnecessary iterations
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime);
        }
        else
        {
            isPrime = false;
            Console.WriteLine(isPrime);
        }
    }
}

