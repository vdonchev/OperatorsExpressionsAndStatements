using System;

class OddEvenSum
{
    static void Main()
    {
        int totalNums = int.Parse(Console.ReadLine());
        int oddSum = 0;
        int evenSum = 0;

        for (int i = 0; i < (totalNums * 2); i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                oddSum += num;
            }
            else
            {
                evenSum += num;
            }
        }

        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes, sum={0}", evenSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(oddSum - evenSum));
        }
    }
}