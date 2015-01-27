//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.
using System;

class FormattingNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter (int) number (number >=0, number <= 500) : ");
        int a = Int32.Parse(Console.ReadLine());
        string XeksaA = Convert.ToString(a, 16);
        while (a < 0 || a > 500)
        {
            Console.WriteLine("Your numeb is not correct: ");
            a = Int32.Parse(Console.ReadLine());
        }
        string binaryA = Convert.ToString(a, 2).PadLeft(10, '0');
        Console.WriteLine("Enter (double) number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter (double) number: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("{0,-10 : X} ", XeksaA);
        Console.Write("|{0:D10}", binaryA);
        Console.Write("|{0, 10:F2}", b);
        Console.WriteLine("|{0, -10:F3}|", c);
    }
}
