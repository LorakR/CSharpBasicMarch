/*Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. */

using System;

class NumberAsWords
{
    static void Main()
    {
        Console.WriteLine("Enter a number in the range [0..999]");
        int number = int.Parse(Console.ReadLine());
        int hundreds = (number / 100) % 10;
        int tens = (number / 10) % 10;
        int ones = number % 10;
        if (number == 0)
        {
            Console.WriteLine("Zero");
        }
        if (hundreds != 0)
        {
            switch (hundreds)
            {
                case 1:
                    Console.Write("One "); break;
                case 2:
                    Console.Write("Two "); break;
                case 3:
                    Console.Write("Three "); break;
                case 4:
                    Console.Write("Four "); break;
                case 5:
                    Console.Write("Five "); break;
                case 6:
                    Console.Write("Six "); break;
                case 7:
                    Console.Write("Seven "); break;
                case 8:
                    Console.Write("Eight "); break;
                case 9:
                    Console.Write("Nine "); break;
                default:
                    Console.Write("Invalid"); break;
            }
            Console.Write("hundred ");
            if (tens != 0 || ones != 0)
            {
                Console.Write("and ");
            }
        }
        if (tens == 1)
            {
                switch (ones)
                {
                    case 0:
                        Console.WriteLine("ten"); break;
                    case 1:
                        Console.WriteLine("eleven"); break;
                    case 2:
                        Console.WriteLine("twelve"); break;
                    case 3:
                        Console.WriteLine("thirteen"); break;
                    case 4:
                        Console.WriteLine("fourteen"); break;
                    case 5:
                        Console.WriteLine("fifteen"); break;
                    case 6:
                        Console.WriteLine("sixteen"); break;
                    case 7:
                        Console.WriteLine("seventeen"); break;
                    case 8:
                        Console.WriteLine("eighteen"); break;
                    case 9:
                        Console.WriteLine("nineteen"); break;
                    default:
                        Console.WriteLine("Invalid"); break;
                 }
             }
        else if (tens > 1)
        {
            switch (tens)
            {
                case 2:
                    Console.Write("twenty "); break;
                case 3:
                    Console.Write("thirty "); break;
                case 4:
                    Console.Write("forty "); break;
                case 5:
                    Console.Write("fifty "); break;
                case 6:
                    Console.Write("sixty "); break;
                case 7:
                    Console.Write("seventy "); break;
                case 8:
                    Console.Write("eighty "); break;
                case 9:
                    Console.Write("ninety "); break;
                default:
                    Console.WriteLine("Invalid"); break;
            }
        }
        if (tens != 1 && ones != 0)
        {
            switch (ones)
            {
                case 1:
                    Console.WriteLine("one"); break;
                case 2:
                    Console.WriteLine("two"); break;
                case 3:
                    Console.WriteLine("three"); break;
                case 4:
                    Console.WriteLine("four"); break;
                case 5:
                    Console.WriteLine("five"); break;
                case 6:
                    Console.WriteLine("six"); break;
                case 7:
                    Console.WriteLine("seven"); break;
                case 8:
                    Console.WriteLine("eight"); break;
                case 9:
                    Console.WriteLine("nine"); break;
                default:
                    Console.WriteLine("Invalid"); break;
            }
        }
        Console.WriteLine();
    }
}

