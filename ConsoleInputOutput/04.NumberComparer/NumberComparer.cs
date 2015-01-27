//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine((a >= b) ? a : b);
    }
}
