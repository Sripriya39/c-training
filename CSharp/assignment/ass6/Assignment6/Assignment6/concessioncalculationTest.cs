using System;

class ConcessionControl
{
    public const decimal TotalFare = 500m;
    public string Name { get; set; }
    public int Age { get; set; }

    static void Main()
    {
        Program program = new Program();

        Console.Write("Enter your name: ");
        program.Name = Console.ReadLine();

        Console.Write("Enter your age: ");
        program.Age = Convert.ToInt32(Console.ReadLine());

        ConcessionCalculator calculator = new ConcessionCalculator();
        string concessionMessage = calculator.CalculateConcession(program.Age);

        Console.WriteLine($"Name: {program.Name}, Age: {program.Age}, Concession: {concessionMessage}");
    }
}