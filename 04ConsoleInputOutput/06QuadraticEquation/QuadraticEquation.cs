/*Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).*/

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double root1 = 0;
        double root2 = 0;
        if (a == 0)
        {
            root1 = -c / b;
            Console.WriteLine("This equation is not quadratic and has one real root: {0}", root1);
        }
        double discriminant = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
        if (discriminant == 0)
        {
            root1 = -b /( 2 * a);
            Console.WriteLine("The equation has one real root: x1={0}",root1);
        }
        else if (discriminant > 0)
        {
            root1 = (-b + discriminant) / (2 * a);
            root2 = (-b - discriminant) / (2 * a);
            Console.WriteLine("The equation has two real roots: x1={0} and x2={1}", root1, root2);
        }
        else
        {
            Console.WriteLine("There are no real roots to this equation.");
        }
    }
}

