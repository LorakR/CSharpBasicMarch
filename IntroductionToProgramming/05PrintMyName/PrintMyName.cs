/* Modify the previous application to print your name. */

using System;

class PrintMyName
{
    static void Main()
    {
        //with placeholder 
        string myName = "Anonimcho";
        Console.WriteLine("{0}", myName);

        //with variable 
        Console.WriteLine(myName);

        //common way
        Console.WriteLine("Anonimcho");
    }
}

