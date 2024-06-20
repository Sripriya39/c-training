using System;

class string2
{
    static void Main(string[] args)
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        string reversedWord = ReverseWord(word);

        Console.WriteLine("The reverse of the word is: " + reversedWord);
    }

    static string ReverseWord(string word)
    {
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}