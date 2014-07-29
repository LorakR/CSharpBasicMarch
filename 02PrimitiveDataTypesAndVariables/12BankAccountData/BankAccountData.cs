/*A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.*/

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Pesho";
        string middleName = "Peshkov";
        string lastName = "Peshev";
       //use decimal since balance is used in financial calculations and precision is needed
        decimal balance = 23569856m;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        char euro='\u20AC';
        string bankName = "NatWest";
        string IBAN = "BH 56 AAAA 0000 0123 4567 89";
        long creditCardNum1 = 123456789159875;
        long creditCardNum2 = 789456123597864;
        long creditCardNum3 = 657894592145698;
        Console.WriteLine("Name : {0} {1} {2}",firstName,middleName,lastName);
        Console.WriteLine("Available amount of money : {0} {1} ",balance,euro);
        Console.WriteLine("Bank Name : " + bankName);
        Console.WriteLine("IBAN : " + IBAN);
        Console.Write("Credit card №1 : {0}\nCredit card №2 : {1}\nCredit card №3 : {2}\n",creditCardNum1,creditCardNum2,creditCardNum3);
    }
}

