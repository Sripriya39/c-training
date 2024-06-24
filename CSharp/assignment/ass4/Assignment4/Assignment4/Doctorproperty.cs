using System;

public class Doctor
{
    private int _regnNo;
    private string _name;
    private decimal _feesCharged;

    public int RegnNo
    {
        get { return _regnNo; }
        set { _regnNo = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public decimal FeesCharged
    {
        get { return _feesCharged; }
        set { _feesCharged = value; }
    }

    public void DisplayDoctorInfo()
    {
        Console.WriteLine($"Registration Number: {RegnNo}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Fees Charged: {FeesCharged:C}");
    }
}

class DoctorProperties
{
    static void Main(string[] args)
    {
        Doctor doctor = new Doctor();

        Console.Write("Enter registration number: ");
        doctor.RegnNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter doctor's name: ");
        doctor.Name = Console.ReadLine();

        Console.Write("Enter fees charged: ");
        doctor.FeesCharged = Convert.ToDecimal(Console.ReadLine());

        doctor.DisplayDoctorInfo();

        Console.ReadLine();
    }
}