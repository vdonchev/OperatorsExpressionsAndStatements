using System;

class BitsExchange
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());

        for (int i = 0; i < 3; i++)
        {
            long bit1 = (num >> (3 + i)) & 1;
            long bit2 = (num >> (24 + i)) & 1;

            if (bit1 == 0)
            {
                int mask = ~(1 << (24 + i));
                num = num & mask;
            }
            else
            {
                int mask = 1 << (24 + i);
                num = num | mask;
            }

            if (bit2 == 0)
            {
                int mask = ~(1 << (3 + i));
                num = num & mask;
            }
            else
            {
                int mask = 1 << (3 + i);
                num = num | mask;
            }
        }

        Console.WriteLine(num);
    }
}