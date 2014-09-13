/*Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement.*/

using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int\n2 --> double\n3 --> string");
        int chosenType = int.Parse(Console.ReadLine());
        switch (chosenType)
        {
            case 1:
                Console.Write("Please enter an integer: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a+1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(b+1);
                break;
            case 3:
                Console.WriteLine("Please enter a string: ");
                string c = Console.ReadLine();
                Console.WriteLine(c + "*");
                break;
            default:
                Console.WriteLine("Sorry, the input is invalid.");
                break;
        }
    }
}

