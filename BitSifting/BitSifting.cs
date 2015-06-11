using System;

class BitSifting
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        int sieves = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < sieves; i++)
        {
            long sieve = long.Parse(Console.ReadLine());
            num = num & ~sieve;
        }

        for (int i = 0; i < 64; i++)
        {
            long bits = num >> i & 1;
            count += (bits == 1) ? 1 : 0;
        }

        Console.WriteLine(count);
    }
}