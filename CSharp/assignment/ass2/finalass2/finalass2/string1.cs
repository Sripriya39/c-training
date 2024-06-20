using System;

class string1
{
    static void Main(string[] args)
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        int length = word.Length;

        Console.WriteLine("The length of the word is: " + length);
    }
}