using System;
using System.Linq;

class Letter
{
    static void Main()
    {
        Console.Write("Enter words separated by commas: ");
        string input = Console.ReadLine();

        string[] words = input.Split(',');

        var result = words.Where(w => w.Trim().StartsWith("a", StringComparison.OrdinalIgnoreCase) && w.Trim().EndsWith("m", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Words starting with 'a' and ending with 'm':");
        foreach (var word in result)
        {
            Console.WriteLine(word.Trim());
        }
    }
}