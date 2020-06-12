using System;
using System.Diagnostics;

class HelloWorld
{
    public static void Main(string[] args)
    {
        //Reading command
        string inputCommand = Console.ReadLine();

        //Executing command
        Process.Start("cmd /c "+string.Join(" ", args));
    }
}
