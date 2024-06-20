using System;

class second
{
    static void Main(string[] args)
    {
        Console.Write("Enter a day number (1-7): ");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        string dayName = GetDayName(dayNumber);

        Console.WriteLine("The day is: " + dayName);
    }

    static string GetDayName(int dayNumber)
    {
        switch (dayNumber)
        {
            case 1:
                return "Monday";
            case 2:
                return "Tuesday";
            case 3:
                return "Wednesday";
            case 4:
                return "Thursday";
            case 5:
                return "Friday";
            case 6:
                return "Saturday";
            case 7:
                return "Sunday";
            default:
                return "Invalid day number";
        }
    }
}