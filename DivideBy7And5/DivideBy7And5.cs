using System;

class DivideBy7And5
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool DivideBy7And5 = ((n % 7 == 0) && (n % 5 == 0) && (n != 0));
        Console.WriteLine(DivideBy7And5);
    }
}