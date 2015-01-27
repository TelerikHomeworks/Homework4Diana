//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main(string[] args)
    {
        int count = 0;
        Console.WriteLine("Entet two positive number: ");
        uint start = UInt32.Parse(Console.ReadLine());
        uint end = UInt32.Parse(Console.ReadLine());
        for (uint i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write(i + ",   ");
                count++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("{0} numbers  exist between {1} and {2} such that the reminder of the division by 5 is 0", count, start, end);
    }
}

