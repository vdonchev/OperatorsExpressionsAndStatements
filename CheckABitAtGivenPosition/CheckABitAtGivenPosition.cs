using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int pos = int.Parse(Console.ReadLine());
        bool check = false;

        int bitAtPos = (num >> pos) & 1;
        check = bitAtPos == 1;
        Console.WriteLine(check);
    }
}