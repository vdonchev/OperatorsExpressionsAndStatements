using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isitOdd = (n % 2 == 0) ? false : true;
        Console.WriteLine(isitOdd);
    }
}