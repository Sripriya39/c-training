using System;

class program
{
    public static void Main()
    {
        Console.WriteLine("enter the first integer : ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" enter the second integer : ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 == num2 )
        {
            Console.WriteLine(" the two integers are equal ");
        }

        else
        {
            Console.WriteLine(" the two integers are not equal ");
        }
        Console.ReadLine();
    }
}