using System;
using System.Collections.Generic;

class Program
{
    static int ConvertRomanNumber(string a)
    {
        Dictionary <char, int> romanValues = new Dictionary <char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int result = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (i + 1 < a.Length && romanValues[a[i]] < romanValues[a[i + 1]])
            {
                result -= romanValues[a[i]];
            }
            else
            {
                result += romanValues[a[i]];
            }
        }
        return result;
    }

    static void Main()
    {
        string romanNumber = "MCMXCIV"; 
        int intValue = ConvertRomanNumber(romanNumber);
        Console.WriteLine(intValue);
    }
}