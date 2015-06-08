using System;

class BigAndOdd
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool result;

        if (n > 20 && n % 2 == 1)
        {
            result = true;
        }
        else
        {
            result = false;
        }

        Console.WriteLine(result);
    }
}