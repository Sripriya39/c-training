using System;

public class countletter
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        Console.Write("Enter a letter to count: ");
        char letterToCount = Console.ReadLine()[0]; 

        int count = CountLetterOccurrences(inputString, letterToCount);

        Console.WriteLine($"The letter '{letterToCount}' appears {count} times in the string.");
    }

    public static int CountLetterOccurrences(string inputString, char letterToCount)
    {
        int count = 0;
        foreach (char c in inputString.ToUpper()) 
        {
            if (c == char.ToUpper(letterToCount)) 
            {
                count++;
            }
        }
        return count;
    }
}