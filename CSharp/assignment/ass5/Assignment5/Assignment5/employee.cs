using System;

public class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public float Salary { get; set; }

    public Employee(int empId, string empName, float salary)
    {
        EmpId = empId;
        EmpName = empName;
        Salary = salary;
    }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Employee ID: {EmpId}, Employee Name: {EmpName}, Salary: {Salary}");
    }
}

class EmployeeDetails
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee(101, "Karthi", 50000.0f);
        Employee emp2 = new Employee(102, "Sri", 60000.0f);

        Console.WriteLine("Employee 1 Details:");
        emp1.DisplayEmployeeDetails();

        Console.WriteLine("Employee 2 Details:");
        emp2.DisplayEmployeeDetails();

        Console.ReadLine();
    }
}