/*You are given a number n and 2*n numbers. Write a program to check whether the sum of the first n numbers is equal to the sum of the second n numbers. Print as result “Yes” or “No”. In case of yes, print also the sum. In case of no, print also the difference between the left and the right sums.*/

using System;

class HalfSum
{
    static void Main()
    {
        int countOfNumbers = int.Parse(Console.ReadLine());
        /*The next two variables should be declared here, not in the loops. Otherwise after the end of the loop the variables cannot be used in other calculations*/
        int sumOfFirstNNumbers = 0;
        int sumOfSecondNNumbers = 0;
        //It is said that the program should compare 2*n numbers or (e.g if n=4 ---> 2*4=8 first 4 numbers and second 4 numbers)
        //Therefore I use 2 loops, each working with n numbers
        for (int i = 1; i <=countOfNumbers; i++)
        {
            //this loop asks the user to enter the first n numbers and calculates their sum
            int currentNumber = int.Parse(Console.ReadLine());
            sumOfFirstNNumbers = sumOfFirstNNumbers + currentNumber;
        }
        for (int j = 1; j <= countOfNumbers; j++)
        {
            //this loop asks the user to enter the second n numbers and calculates their sum
            int currentNumber = int.Parse(Console.ReadLine());
            sumOfSecondNNumbers = sumOfSecondNNumbers + currentNumber;
        }
        if (sumOfFirstNNumbers == sumOfSecondNNumbers)
        {
            //It doesn't matter whether we print the sum of the first n numbers or the second n numbers cause in this case they're equal
            Console.WriteLine("Yes, sum=" + sumOfFirstNNumbers);
        }
        else
        {
            //It is said that the difference should always be a positive number
            int difference = Math.Abs(sumOfFirstNNumbers - sumOfSecondNNumbers);
            Console.WriteLine("No, diff="+difference);
        }
    }
}

