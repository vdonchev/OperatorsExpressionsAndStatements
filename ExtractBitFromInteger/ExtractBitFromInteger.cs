using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int pos = int.Parse(Console.ReadLine());

        int bitAtPos = (num >> pos) & 1;
        Console.WriteLine(bitAtPos);
    }
}