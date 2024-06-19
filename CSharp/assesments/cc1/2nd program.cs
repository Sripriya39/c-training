using System;

namespace ExchangeCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();

            if (inputString.Length < 2)
            {
                Console.WriteLine("The string must have at least two characters.");
                return;
            }

            char[] charArray = inputString.ToCharArray();
            char temp = charArray[0];
            charArray[0] = charArray[charArray.Length - 1];
            charArray[charArray.Length - 1] = temp;

            string result = new string(charArray);
            Console.WriteLine(result);
        }
    }
}