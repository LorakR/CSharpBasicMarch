/*Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Print “not a digit” in case of invalid inut. Use a switch statement.*/

using System;

class DigitAsWord
{
    static void Main()
    {
        string enteredNumber = Console.ReadLine();
        int validNumber;
        bool parseSuccess = int.TryParse(enteredNumber, out validNumber);
        if (!parseSuccess)
        {
            Console.WriteLine("not a digit");
        }
        //use switch only if parseSuccess = true since when parseSuccess = false, the variable validNumber will stay with it's default value 0 and the "case 0:" of the switch case will be printed when not needed
        if (parseSuccess)
        {
            switch (validNumber)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                default:
                    Console.WriteLine("not a digit");
                    break;
            }
        }
    }
}

