using System;

class NthDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        double nDigit;

        nDigit = (number / Math.Pow(10, n - 1)) % 10;
        if ((int)nDigit == 0)
        {
            Console.WriteLine('-');
        }
        else
        {
            Console.WriteLine((int)nDigit);
        }
    }
}