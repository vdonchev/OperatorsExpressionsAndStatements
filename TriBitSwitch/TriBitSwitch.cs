using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        long mask = (7 << p);
        long result = (n ^ mask);

        Console.WriteLine(result);
    }
}