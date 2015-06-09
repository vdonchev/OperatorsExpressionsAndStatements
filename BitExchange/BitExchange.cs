using System;

class BitExchange
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        int pos1 = int.Parse(Console.ReadLine());
        int pos2 = int.Parse(Console.ReadLine());
        int numOfBits = int.Parse(Console.ReadLine());

        if (Math.Abs(pos1 - pos2) < numOfBits)
        {
            Console.WriteLine("overlapping");
            return;
        }

        if ((Math.Max(pos1, pos2) + numOfBits) > 31)
        {
            Console.WriteLine("out of range");
            return;
        }

        for (int i = 0; i < numOfBits; i++)
        {
            long bit1 = num >> (pos1 + i) & 1;
            long bit2 = num >> (pos2 + i) & 1;

            if (bit1 == 0)
            {
                int mask = ~(1 << (pos2 + i));
                num = num & mask;
            }
            else
            {
                int mask = 1 << (pos2 + i);
                num = num | mask;
            }

            if (bit2 == 0)
            {
                int mask = ~(1 << (pos1 + i));
                num = num & mask;
            }
            else
            {
                int mask = 1 << (pos1 + i);
                num = num | mask;
            }
        }

        Console.WriteLine(num);
    }
}