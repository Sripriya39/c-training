using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        Display(firstName, lastName);
    }

    public static void Display(string firstName, string lastName)
    {
        Console.WriteLine(firstName.ToUpper());
        Console.WriteLine(lastName.ToUpper());
    }
}