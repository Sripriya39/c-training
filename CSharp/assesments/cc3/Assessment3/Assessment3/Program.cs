using System;

class Cricket
{
    public void Pointscalculation(int no_of_matches)
    {
        int sum = 0;
        for (int i = 0; i < no_of_matches; i++)
        {
            Console.Write("Enter the scores {0}: ", i + 1);
            int score = Convert.ToInt32(Console.ReadLine());
            sum += score;
        }

        double average = (double)sum / no_of_matches;

        Console.WriteLine("Sum of scores: " + sum);
        Console.WriteLine("Average score: " + average);
    }
}

class Match
{
    static void Main(string[] args)
    {
        Cricket cricket = new Cricket();
        Console.WriteLine(" Welcome to cricket world !!! ");
        Console.Write("Enter the number of matches: ");
        int no_of_matches = Convert.ToInt32(Console.ReadLine());
        cricket.Pointscalculation(no_of_matches);
    }
}