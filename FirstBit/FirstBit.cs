using System;

class FirstBit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int bitAtPostion1;

        bitAtPostion1 = (n >> 1) & 1;
        Console.WriteLine(bitAtPostion1);
    }
}