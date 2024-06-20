using System;

class string3
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first word: ");
        string word1 = Console.ReadLine();

        Console.Write("Enter the second word: ");
        string word2 = Console.ReadLine();

        bool areWordsSame = AreWordsSame(word1, word2);

        if (areWordsSame)
        {
            Console.WriteLine("The two words are the same.");
        }
        else
        {
            Console.WriteLine("The two words are not the same.");
        }
    }

    static bool AreWordsSame(string word1, string word2)
    {
        return word1.Equals(word2, StringComparison.OrdinalIgnoreCase);
    }
}