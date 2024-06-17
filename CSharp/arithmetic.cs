using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

       
        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        
        double sum = number1 + number2;
        double difference = number1 - number2;
        double product = number1 * number2;
        double quotient = 0;

        if (number2 != 0)
        {
            quotient = number1 / number2;
        }

       
        Console.WriteLine($"Sum: {number1} + {number2} = {sum}");
        Console.WriteLine($"Difference: {number1} - {number2} = {difference}");
        Console.WriteLine($"Product: {number1} * {number2} = {product}");

        if (number2 != 0)
        {
            Console.WriteLine($"Quotient: {number1} / {number2} = {quotient}");
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
        }
    }
}
