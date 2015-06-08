using System;

class FourDigitNumber
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int fourthDigit = num % 10;

        int thirdDigit = (num / 10) % 10;

        int secondDigit = (num / 100) % 10;

        int firstDigit = (num / 1000) % 10;

        Console.WriteLine("Sum of digits: {0}", firstDigit + secondDigit + thirdDigit + fourthDigit);
        Console.WriteLine("Reversed order: {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
        Console.WriteLine("Last on first: {3}{0}{1}{2}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("Switch second and third: {0}{2}{1}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
    }
}