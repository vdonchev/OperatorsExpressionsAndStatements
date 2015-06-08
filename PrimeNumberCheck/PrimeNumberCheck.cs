using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isPrime = false;
        int found = 0;

        for (int i = 2; i <= n; i++)
        {
            if (n % i == 0)
            {
                found++;
            }
        }

        if (found == 1)
        {
            isPrime = true;
        }

        Console.WriteLine(isPrime);
    }
}