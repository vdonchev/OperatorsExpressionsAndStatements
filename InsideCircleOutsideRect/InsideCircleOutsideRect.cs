using System;

class InsideCircleOutsideRect
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool point = ((x * x) - 1) + ((y * y) - 1) <= 2.5 * 2.5 && y > 1;

        Console.WriteLine("Inside a circle and outside of a reactangle: {0}", point ? "yes" : "no");
    }
}