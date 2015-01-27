//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

class CirclePerimeterAndArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter radius: ");
        double r = double.Parse(Console.ReadLine());
        double п = Math.PI;
        double p = 2 * п * r;
        double s = п * r * r;
        Console.WriteLine("P = 2 * п * r = {0:F2}", p);
        Console.WriteLine("S = п * r * r = {0:F2}", s);

    }
}

