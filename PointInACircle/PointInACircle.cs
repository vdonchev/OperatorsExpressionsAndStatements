using System;

class PointInACircle
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        bool check = (x * x) + (y * y) <= (2 * 2);
        Console.WriteLine(check);
    }
}