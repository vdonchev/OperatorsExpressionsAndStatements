using System;

class BitExchange
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        int pos1 = int.Parse(Console.ReadLine());
        int pos2 = int.Parse(Console.ReadLine());
        int bits = int.Parse(Console.ReadLine());

        if (Math.Min(pos1, pos2) < 0 || Math.Max(pos1, pos2) > 31 || Math.Max(pos1, pos2) + bits > 31)
        {
            Console.WriteLine("out of range");
            return;
        }
        else if (Math.Abs(pos1 - pos2) <= bits)
        {
            Console.WriteLine("overlapping");
            return;
        }

        for (int i = 0; i < bits; i++)
        {
            long bit1 = num >> (pos1 + i) & 1;
            long bit2 = num >> (pos2 + i) & 1;

            if (bit1 == 0)
            {
                num = num & ~(1 << (pos2 + i));
            }
            else
            {
                num = num | 1 << (pos2 + i);
            }

            if (bit2 == 0)
            {
                num = num & ~(1 << (pos1 + i));
            }
            else
            {
                num = num | 1 << (pos1 + i);
            }
        }

        Console.WriteLine(num);
    }
}