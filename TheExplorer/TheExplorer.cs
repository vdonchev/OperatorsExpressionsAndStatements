using System;

class TheExplorer
{
    static void Main()
    {
        int diamondSize = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string('-', diamondSize / 2));
        
        int inner = 1;
        int outter = (diamondSize - 3) / 2;

        // print top part
        for (int i = 0; i < (diamondSize / 2); i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', outter), new string('-', inner));
            inner += 2;
            outter--;
        }

        inner = diamondSize - 4;
        outter = 1;

        // print bottom part
        for (int i = 1; i < (diamondSize / 2); i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', outter), new string('-', inner));
            inner -= 2;
            outter++;
        }

        Console.WriteLine("{0}*{0}", new string('-', diamondSize / 2));
    }
}