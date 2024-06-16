using System;

class posneg
{
    public static void Main()
    {
        Console.WriteLine("enter the number ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine(" the number is positive ");
        }
        else if (number < 0)
        {
            Console.WriteLine(" the number is negative ");
        }
        else
        {
            Console.WriteLine(" the number is zero ");
        }
        Console.ReadLine();
    }
}