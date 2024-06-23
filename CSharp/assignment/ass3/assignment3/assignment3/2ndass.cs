using System;

public class Student
{
    private int rollNo;
    private string name;
    private string className;
    private string semester;
    private string branch;
    private int[] marks;

    public Student(int rollNo, string name, string className, string semester, string branch)
    {
        this.rollNo = rollNo;
        this.name = name;
        this.className = className;
        this.semester = semester;
        this.branch = branch;
        this.marks = new int[5];
    }

    public void GetMarks()
    {
        Console.WriteLine("Enter marks for 5 subjects:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Subject {i + 1}: ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public void DisplayResult()
    {
        int totalMarks = 0;
        bool isFailed = false;

        for (int i = 0; i < 5; i++)
        {
            if (marks[i] < 35)
            {
                isFailed = true;
                break;
            }
            totalMarks += marks[i];
        }

        double average = totalMarks / 5.0;

        if (isFailed)
        {
            Console.WriteLine("Result: Failed");
        }
        else if (average < 50)
        {
            Console.WriteLine("Result: Failed");
        }
        else
        {
            Console.WriteLine("Result: Passed");
        }
    }

    public void DisplayData()
    {
        Console.WriteLine($"Roll No: {rollNo}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Class: {className}");
        Console.WriteLine($"Semester: {semester}");
        Console.WriteLine($"Branch: {branch}");
        Console.WriteLine("Marks:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Subject {i + 1}: {marks[i]}");
        }
    }
}

public class Prog2
{
    public static void Main(string[] args)
    {
        Console.Write("Enter roll no: ");
        int rollNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter class: ");
        string className = Console.ReadLine();

        Console.Write("Enter semester: ");
        string semester = Console.ReadLine();

        Console.Write("Enter branch: ");
        string branch = Console.ReadLine();

        Student student = new Student(rollNo, name, className, semester, branch);

        student.GetMarks();
        student.DisplayData();
        student.DisplayResult();

        Console.ReadLine();
    }
}