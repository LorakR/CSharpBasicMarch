/*Print sunglasses on the console. Input integer N --> the height of the glasses. The sunglasses consist of three parts: frame"*",   lenses"/" and a bridge(the connection between the two frames)"|"          */

using System;

class Sunglasses
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        //this prints the upper frames 
        Console.WriteLine("{0}{1}{0}",new string('*',N*2),new string(' ',N));
        //this prints the lenses and the side frames
        for (int i = 1; i <= N - 2; i++)
        {
            //this prints the middle line, where the bridge connects the frames
            if (i == N / 2)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('/', N * 2 - 2), new string('|', N));
            }
            else
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('/', N * 2 - 2), new string(' ', N));
            }
        }
        //this prints the bottom frames
        Console.WriteLine("{0}{1}{0}", new string('*', N * 2), new string(' ', N));
    }
}

