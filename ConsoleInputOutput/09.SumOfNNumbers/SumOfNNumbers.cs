//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
using System;

class SumOfNNumbers
{
    static void Main(string[] args)
    {
        float num;
        float sum = 0.0f;
        Console.WriteLine("Enter number: ");
        int n = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} numbers: ", n);
        for (int i = 0; i < n; i++)
        {
            num = float.Parse(Console.ReadLine());
            sum += num;
        }
        Console.WriteLine(sum);
    }
}

