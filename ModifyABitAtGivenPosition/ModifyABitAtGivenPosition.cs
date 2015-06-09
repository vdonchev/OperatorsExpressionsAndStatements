using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int pos = int.Parse(Console.ReadLine());
        int val = int.Parse(Console.ReadLine());
        int mask;

        if (val == 0)
        {
            mask = ~(1 << pos);
            num = num & mask;
        }
        else
        {
            mask = 1 << pos;
            num = num | mask;
        }

        Console.WriteLine(num);
    }
}