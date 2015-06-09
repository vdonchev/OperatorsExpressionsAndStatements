using System;

class ExtractBit3
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int bitAt3 = (num >> 3) & 1;
        Console.WriteLine(bitAt3);
    }
}