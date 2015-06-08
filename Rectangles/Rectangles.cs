using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double heigth = double.Parse(Console.ReadLine());
        double permiter, area;
        permiter = (width * 2) + (heigth * 2);
        area = width * heigth;
        Console.WriteLine("Permiter is: {0}\nArea is: {1}", permiter, area);
    }
}