/*Write a program to read your birthday from the console and print how old you are now and how old you will be 
 after 10 years.*/

using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter your birthday date in the format dd.mm.yyyy");
        //Declare a variable of type DateTime
        DateTime birthDate;
        //(1)check whether the user has entered a date in the correct format 
        //(2)the keyword "out" means that the parsed value of the entered string will be assigned to the variable birthDate
        //(3)the "TryParse" method returns value of type bool --> true or false
        //(4)use "TryParse" instead of "Parse" in order to catch possible Exceptions and in such case - give the user
        //chance to enter another valid date
        bool validDate = DateTime.TryParse(Console.ReadLine(), out birthDate);
        while (!(validDate == true))
        {
            Console.WriteLine("You have entered invalid date! Please, try again");
            validDate = DateTime.TryParse(Console.ReadLine(), out birthDate);
        }
        DateTime currentDate = DateTime.Now;
        int age = currentDate.Year - birthDate.Year;
        //check wheter the year entered by the user is in the future
        if (currentDate.Year < birthDate.Year)
        {
            Console.WriteLine("Man, you seem not to be born yet ..");
        }
        //check whether the age has not been turned yet
        else if ((currentDate.Month < birthDate.Month) || ((currentDate.Month == birthDate.Month) && (currentDate.Day < birthDate.Day)))
        {
            age--;
        }
        int ageAfter = age + 10;
        Console.WriteLine("Your age now is {0}", age);
        Console.WriteLine("Your age after ten years will be {0}", ageAfter);
    }
}
