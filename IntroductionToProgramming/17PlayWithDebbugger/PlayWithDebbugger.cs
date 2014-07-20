/*Write a program that prints at the console the numbers from 1 to 1000, each at a separate line. 
Set a breakpoint in the line, which prints the next number in the Visual Studio code editor. 
Run the program through the debugger using the [F5] key. 
When the debugger stops at the breakpoint trace the code execution with [F10] key.*/

using System;

class PlayWithDebugger
{
    static void Main()
    {
        for (int i = 1; i <= 1000; i++)
        {
            Console.WriteLine(i);
        }
    }
}
