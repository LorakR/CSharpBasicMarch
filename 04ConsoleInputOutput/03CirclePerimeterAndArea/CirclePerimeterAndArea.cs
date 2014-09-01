/*Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. */

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * Math.Pow(radius, 2);
        double perimeter = 2 * Math.PI * radius;
        //{index[,alignment][:formatString]} ---> formatString specifies the format of the corresponding arguments
        Console.WriteLine("The area of the circle is {0:0.00}",area);
        Console.WriteLine("The perimeter of the cirle is {0:0.00}",perimeter);
    }
}

