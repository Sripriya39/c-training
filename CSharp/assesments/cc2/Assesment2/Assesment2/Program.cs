using System;

public abstract class Student
{
    public string Name
    {
        get;
        set; 
    }
    public int StudentId
    {
        get;
        set; 
    }
    public double Grade
    { 
        get;
        set;
    }

    public abstract bool IsPassed(double grade);
}


public class Undergraduate : Student
{
    public override bool IsPassed(double grade)
    {
        return grade > 70.0;
    }
}

public class Graduate : Student
{
    public override bool IsPassed(double grade)
    {
        return grade > 80.0;
    }
}


class StudentGrade
{
    static void Main(string[] args)
    {

        Undergraduate ug = new Undergraduate
        {
            Name = "karthikeyan",
            StudentId = 213,
            Grade = 75.0
        };
        Console.WriteLine($"Undergraduate {ug.Name} is passed? : {ug.IsPassed(ug.Grade)}");

        Graduate grad = new Graduate
        {
            Name = "Sripriya",
            StudentId = 321,
            Grade = 70.0
        };
        Console.WriteLine($"Graduate {grad.Name} is passed? : {grad.IsPassed(grad.Grade)}");
    }
}