//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumOfFiveNumbers
{
    static void Main(string[] args)
    {
        float sum = 0.0f;
        Console.WriteLine("Enter five numbers:");
        string[] array = new string[5];
        array = Console.ReadLine().Split();
        for (int i = 0; i < array.Length; i++)
        {
            float element = float.Parse(array[i]);
            sum += element;
        }
        Console.WriteLine(sum);
    }
}
