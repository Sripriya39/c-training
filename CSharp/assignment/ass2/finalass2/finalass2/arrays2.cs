using System;

class arrays2
{
    static void Main(string[] args)
    {
        int[] marks = new int[10];

        Console.WriteLine("Enter 10 marks:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Mark {0}: ", i + 1);
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        int total = CalculateTotal(marks);
        double average = CalculateAverage(marks);
        int min = FindMin(marks);
        int max = FindMax(marks);

        Array.Sort(marks); // sort in ascending order
        int[] descendingMarks = (int[])marks.Clone(); // clone the array
        Array.Sort(descendingMarks); // sort in descending order
        Array.Reverse(descendingMarks); // reverse the array to get descending order

        Console.WriteLine("Total: " + total);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Minimum marks: " + min);
        Console.WriteLine("Maximum marks: " + max);
        Console.WriteLine("Marks in ascending order: ");
        PrintArray(marks);
        Console.WriteLine("Marks in descending order: ");
        PrintArray(descendingMarks);
    }

    static int CalculateTotal(int[] marks)
    {
        int total = 0;
        foreach (int mark in marks)
        {
            total += mark;
        }
        return total;
    }

    static double CalculateAverage(int[] marks)
    {
        return (double)CalculateTotal(marks) / marks.Length;
    }

    static int FindMin(int[] marks)
    {
        int min = marks[0];
        foreach (int mark in marks)
        {
            if (mark < min)
            {
                min = mark;
            }
        }
        return min;
    }

    static int FindMax(int[] marks)
    {
        int max = marks[0];
        foreach (int mark in marks)
        {
            if (mark > max)
            {
                max = mark;
            }
        }
        return max;
    }

    static void PrintArray(int[] marks)
    {
        foreach (int mark in marks)
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();
    }
}