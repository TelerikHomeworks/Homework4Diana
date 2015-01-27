//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class  SumOfThreeNumbers
{
    static void Main(string[] args)
    {
        int sum = 0;
        int num;
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Enter number {0} from the keyboard", i);
            num = Int32.Parse(Console.ReadLine());
            sum += num;
        }
        Console.WriteLine("sum = {0}", sum);
    }
}

