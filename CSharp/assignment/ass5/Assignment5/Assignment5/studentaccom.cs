using System;

public interface IStudent
{
    int StudentId { get; set; }
    string Name { get; set; }
    void ShowDetails();
}

public class Dayscholar : IStudent
{
    public int StudentId { get; set; }
    public string Name { get; set; }

    public Dayscholar(int studentId, string name)
    {
        StudentId = studentId;
        Name = name;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Student ID: {StudentId}, Name: {Name}, Type: Day Scholar");
    }
}

public class Resident : IStudent
{
    public int StudentId { get; set; }
    public string Name { get; set; }

    public Resident(int studentId, string name)
    {
        StudentId = studentId;
        Name = name;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Student ID: {StudentId}, Name: {Name}, Type: Resident");
    }
}

class StudentAccom
{
    static void Main(string[] args)
    {
        Dayscholar dayscholar = new Dayscholar(101, "Sripriya");
        Resident resident = new Resident(102, "Karthi");

        Console.WriteLine("Dayscholar Details:");
        dayscholar.ShowDetails();

        Console.WriteLine("Resident Details:");
        resident.ShowDetails();

        Console.ReadLine();
    }
}