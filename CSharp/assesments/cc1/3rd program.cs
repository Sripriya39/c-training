using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three integers separated by spaces:");
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');

            if (numbers.Length != 3)
            {
                Console.WriteLine("Please enter exactly three integers.");
                return;
            }

            int[] numArray = new int[3];

            for (int i = 0; i < 3; i++)
            {
                if (!int.TryParse(numbers[i], out numArray[i]))
                {
                    Console.WriteLine("Invalid input. Please enter three integers.");
                    return;
                }
            }

            int largest = numArray[0];

            for (int i = 1; i < 3; i++)
            {
                if (numArray[i] > largest)
                {
                    largest = numArray[i];
                }
            }

            Console.WriteLine("The largest number is: " + largest);
        }
    }
}
