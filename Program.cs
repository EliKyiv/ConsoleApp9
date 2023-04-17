using System;

delegate void PrintString(string input);

class Program
{
    static void Main(string[] args)
    {
        PrintString greenPrinter = PrintInGreen;
        PrintString orangePrinter = PrintInOrange;

        greenPrinter("Hello, world!");
        orangePrinter("Greetings, earthling!");
    }

    static void PrintInGreen(string input)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(input);
        Console.ResetColor();
    }

    static void PrintInOrange(string input)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(input);
        Console.ResetColor();
    }
}