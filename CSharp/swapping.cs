using System;

class Program
{
    static void Main()
    {
        // Prompt the user for input
        Console.Write("Enter a digit: ");
        string input = Console.ReadLine();

        // Display the input four times separated by spaces using {0} placeholder
        Console.WriteLine("{0} {0} {0} {0}", input);

        // Display the input four times with no separation using {0} placeholder
        Console.WriteLine("{0}{0}{0}{0}", input);

        // Repeat the same lines to match the expected output
        Console.WriteLine("{0} {0} {0} {0}", input);
        Console.WriteLine("{0}{0}{0}{0}", input);
    }
}
