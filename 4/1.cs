using System;

class Program
{
    static int RomanToInt(string s)
    {
        int result = 0;
        int prevValue = 0;

        foreach (char c in s)
        {
            int value = 0;

            switch (c)
            {
                case 'I':
                    value = 1;
                break;
                case 'V':
                    value = 5;
                break;
                case 'X':
                    value = 10;
                break;
                case 'L':
                    value = 50;
                break;
                case 'C':
                    value = 100;
                break;
                case 'D':
                    value = 500;
                break;
                case 'M':
                    value = 1000;
                break;
            }

            if (value > prevValue)
            {
                result -= 2 * prevValue;
            }

            result += value;
            prevValue = value;
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter a Roman numeral:");
        string romanNumber = Console.ReadLine();
        Console.WriteLine($"Roman numeral {romanNumber} equals {RomanToInt(romanNumber)} in Arabic.");
        Console.ReadKey();
    }
}