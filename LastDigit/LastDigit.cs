using System;

class LastDigit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int result;

        result = n % 10;
        Console.WriteLine(result);
    }
}