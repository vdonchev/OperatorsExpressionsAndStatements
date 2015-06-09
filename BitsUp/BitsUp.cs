using System;

class BitsUp
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;
        int innerStep = 1;

        for (int i = 0; i < count; i++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int j = 7; j >= 0; j--)
            {
                if (index == innerStep)
                {
                    num = num | (1 << j);
                    innerStep += step;
                }
                index++;
            }
            Console.WriteLine(num);
        }
    }
}