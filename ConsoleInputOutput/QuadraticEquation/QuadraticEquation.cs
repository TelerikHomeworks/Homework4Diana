using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value of a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of c: ");
        double c = double.Parse(Console.ReadLine());
        double D =(b * b) -(4 * a * c);
        if (D < 0)
        {
            Console.WriteLine("No real roots");
        }
        else
            if (D == 0)
            {
                Console.WriteLine("x1 = x2 = " + ((-b) / (2 * a)));
            }
            else
            {
                Console.WriteLine("x1 = {0}     x2 = {1}", (((-b) + Math.Sqrt(D)) / (2 * a)), (((-b) - Math.Sqrt(D)) / (2 * a)));
            }
    }
}

