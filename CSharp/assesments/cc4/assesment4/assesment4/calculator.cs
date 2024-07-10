using System;

class Calculator
{
    delegate int CalculatorDelegate(int num1, int num2);

    static void Main()
    {
        Console.WriteLine("Calculator Functionalities");
        Console.WriteLine("*******************");

        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        CalculatorDelegate addDelegate = Add;
        CalculatorDelegate subtractDelegate = Subtract;
        CalculatorDelegate multiplyDelegate = Multiply;

        int resultAdd = addDelegate(num1, num2);
        int resultSubtract = subtractDelegate(num1, num2);
        int resultMultiply = multiplyDelegate(num1, num2);

        
        Console.WriteLine($"Addition: {num1} + {num2} = {resultAdd}");
        Console.WriteLine($"Subtraction: {num1} - {num2} = {resultSubtract}");
        Console.WriteLine($"Multiplication: {num1} * {num2} = {resultMultiply}");
    }

    static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
}