using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public string EmpCity { get; set; }
    public decimal EmpSalary { get; set; }
}

class EmployeeDetails
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "ss", EmpCity = "Bangalore", EmpSalary = 50000m },
            new Employee { EmpId = 2, EmpName = "jana", EmpCity = "Chennai", EmpSalary = 42000m },
            new Employee { EmpId = 3, EmpName = "Raj", EmpCity = "Bangalore", EmpSalary = 48000m },
            new Employee { EmpId = 4, EmpName = "karti", EmpCity = "Hyderabad", EmpSalary = 55000m },
            new Employee { EmpId = 5, EmpName = "vidhu", EmpCity = "Bangalore", EmpSalary = 40000m },
            new Employee { EmpId = 6, EmpName = "priya", EmpCity = "Mumbai", EmpSalary = 52000m },
            new Employee { EmpId = 7, EmpName = "gowshi", EmpCity = "Bangalore", EmpSalary = 45000m },
        };

        
        Console.WriteLine("All Employees Data:");
        foreach (var employee in employees)
        {
            Console.WriteLine($"EmpId: {employee.EmpId}, EmpName: {employee.EmpName}, EmpCity: {employee.EmpCity}, EmpSalary: {employee.EmpSalary:C}");
        }

        Console.WriteLine();

        
        Console.WriteLine("Employees with salary greater than 45000:");
        foreach (var employee in employees.Where(e => e.EmpSalary > 45000m))
        {
            Console.WriteLine($"EmpId: {employee.EmpId}, EmpName: {employee.EmpName}, EmpCity: {employee.EmpCity}, EmpSalary: {employee.EmpSalary:C}");
        }

        Console.WriteLine();

        
        Console.WriteLine("Employees from Bangalore Region:");
        foreach (var employee in employees.Where(e => e.EmpCity == "Bangalore"))
        {
            Console.WriteLine($"EmpId: {employee.EmpId}, EmpName: {employee.EmpName}, EmpCity: {employee.EmpCity}, EmpSalary: {employee.EmpSalary:C}");
        }

        Console.WriteLine();

        
        Console.WriteLine("Employees in Ascending order by Name:");
        foreach (var employee in employees.OrderBy(e => e.EmpName))
        {
            Console.WriteLine($"EmpId: {employee.EmpId}, EmpName: {employee.EmpName}, EmpCity: {employee.EmpCity}, EmpSalary: {employee.EmpSalary:C}");
        }
    }
}