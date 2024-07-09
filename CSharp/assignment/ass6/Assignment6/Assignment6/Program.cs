using System;
using System.Linq;

class Program
{
    public string Name { get; internal set; }
    public int Age { get; internal set; }

    static void Main()
    {
        Console.Write("Enter numbers separated by space: ");
        string input = Console.ReadLine();
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

        var result = numbers.Where(n => n * n > 20)
                           .Select(n => $"{n} - {n * n}");

        Console.WriteLine("Numbers and their squares:");
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}