using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2
{

    class NumberCheckException
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter an integer: ");
                int number = Convert.ToInt32(Console.ReadLine());
                CheckNumberispositive(number);
                Console.WriteLine("yes , Number is positive.");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void CheckNumberispositive(int number)
        {
            if (number < 0)
            {
                throw new Exception("Number cannot be negative.");
            }
        }
    }
}
