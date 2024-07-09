public class ConcessionCalculator
{
    public string CalculateConcession(int age)
    {
        if (age <= 5)
        {
            return "Little Champs - Free Ticket";
        }
        else if (age > 60)
        {
            decimal totalFare = 500m;
            decimal concession = totalFare * 0.3m;
            decimal fareAfterConcession = totalFare - concession;
            return $"Senior Citizen - {fareAfterConcession:C}";
        }
        else
        {
            return $"Print Ticket Booked - 500";
        }
    }
}