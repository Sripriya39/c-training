using System;

public class Box
{
    public int Length { get; set; }
    public int Breadth { get; set; }

    public Box(int length, int breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    public static Box AddBoxes(Box box1, Box box2)
    {
        Box result = new Box(box1.Length + box2.Length, box1.Breadth + box2.Breadth);
        return result;
    }

    public void Display()
    {
        Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
    }
}

public class Test
{
    static void Main(string[] args)
    {
        Box box1 = new Box(5, 3);
        Box box2 = new Box(7, 4);

        Console.WriteLine("Box 1:");
        box1.Display();

        Console.WriteLine("Box 2:");
        box2.Display();

        Box box3 = Box.AddBoxes(box1, box2);

        Console.WriteLine("Box 3 (Result of adding Box 1 and Box 2):");
        box3.Display();

        Console.ReadLine();
    }
}