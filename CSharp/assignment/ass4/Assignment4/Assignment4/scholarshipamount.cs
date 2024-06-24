using System;

public class Scholarship
{
    public void Merit(int marks, decimal fees)
    {
        decimal scholarshipAmount = 0;

        if (marks >= 70 && marks <= 80)
        {
            scholarshipAmount = fees * 0.20m;
        }
        else if (marks > 80 && marks <= 90)
        {
            scholarshipAmount = fees * 0.30m;
        }
        else if (marks > 90)
        {
            scholarshipAmount = fees * 0.50m;
        }
        else
        {
            Console.WriteLine("No scholarship is awarded.");
            return;
        }

        Console.WriteLine($"Scholarship amount: {scholarshipAmount:C}");
    }
}

class ScholarshipAmount
{
    static void Main(string[] args)
    {
        Scholarship scholarship = new Scholarship();

        Console.Write("Enter your marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the fees: ");
        decimal fees = Convert.ToDecimal(Console.ReadLine());

        scholarship.Merit(marks, fees);

        Console.ReadLine();
    }
}