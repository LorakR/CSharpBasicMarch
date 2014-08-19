/*Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). */

using System;

class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2) <= 1.5 * 1.5;
        bool isInRectangle = ((x >= -1 && x <= 5) && ( y >= -1 && y <= 1));
        if (isInCircle && !isInRectangle)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

