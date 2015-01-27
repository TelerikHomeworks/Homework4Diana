//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,)

using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter number");
        int n = Int32.Parse(Console.ReadLine());
         int[] array1 = new int[n];

        array1[0] = 0;
        array1[1] = 1;
        Console.Write(array1[0]+", " + array1[1] + ", ");
        for (int i = 2; i < n; i++)
        {
            array1[i] = array1[i - 2] + array1[i - 1];
            Console.Write(array1[i] +", ");
        }
        Console.WriteLine();
    }
}

