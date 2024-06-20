using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first integer: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int result = ComputeSum(num1, num2);

        Console.WriteLine("The result is: " + result);
    }

    static int ComputeSum(int num1, int num2)
    {
        if (num1 == num2)
        {
            return 3 * (num1 + num2);
        }
        else
        {
            return num1 + num2;
        }
    }
}