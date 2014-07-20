/*Create console application that prints your first and last name, each at a separate line.*/

using System;

class PrintFirstAndLastName
{
    static void Main()
    {
        //common way
        Console.WriteLine("Pesho");
        Console.WriteLine("Peshev");

        //empty line for better visualisation
        Console.WriteLine();

        //with a placeholder and variable from type string
        string firstName = "Pesho";
        string lastName = "Peshev";
        Console.WriteLine("{0}\n{1}", firstName, lastName);
    }
}
