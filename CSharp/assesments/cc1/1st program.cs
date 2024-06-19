using System;

namespace RemoveCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give your string: ");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter the position of the character to remove: ");
            int pos = Convert.ToInt32(Console.ReadLine());

            
            if (pos < 0 || pos > inputString.Length - 1)
            {
                Console.WriteLine("Sorry, invalid position.");
                return;
            }

            
            string result = inputString.Remove(pos, 1);
            Console.WriteLine("Resulting string: " + result);
        }
    }
}