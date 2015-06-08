using System;

class Program
{
    static void Main()
    {
        int binary = 111;
        Console.WriteLine(Convert.ToString(binary, 2));

        long n = long.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        long mask = (7 << p);
        long result = (n ^ mask);

        Console.WriteLine(result);
    }
}