using System;

class Box
{
    public int Length
    { 
        get;
        set; 
    }
    public int Breadth
    {
        get;
        set;
    }

    public Box(int length, int breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    public static Box AddBox(Box box1, Box box2)
    {
        Box box3 = new Box(box1.Length + box2.Length, box1.Breadth + box2.Breadth);
        return box3;
    }

    public void Display()
    {
        Console.WriteLine("Length: " + Length);
        Console.WriteLine("Breadth: " + Breadth);
    }
}

class Test
{
    static void Main(string[] args)
    {
        Console.Write("Enter length of Box 1: ");
        int length1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter breadth of Box 1: ");
        int breadth1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter length of Box 2: ");
        int length2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter breadth of Box 2: ");
        int breadth2 = Convert.ToInt32(Console.ReadLine());

        Box box1 = new Box(length1, breadth1);
        Box box2 = new Box(length2, breadth2);

        Box box3 = Box.AddBox(box1, box2);

        Console.WriteLine("Box 1 details:");
        box1.Display();

        Console.WriteLine("Box 2 details:");
        box2.Display();

        Console.WriteLine("Box 3 details:");
        box3.Display();
    }
}