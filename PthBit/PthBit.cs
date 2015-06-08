using System;

class PthBit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int bitAtPositionP;

        bitAtPositionP = (n >> p) & 1;
        Console.WriteLine(bitAtPositionP);
    }
}