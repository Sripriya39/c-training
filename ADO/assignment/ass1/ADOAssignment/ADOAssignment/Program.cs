using System;
using System.Collections.Generic;

namespace ADOAssignment
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>
            {
                new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
                new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
                new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
                new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
                new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
                new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
            };

            // 1. Display a list of all the employees who have joined before 1/1/2015:
            List<Employee> joinedBefore2015 = new List<Employee>();
            DateTime date2015 = new DateTime(2015, 1, 1);

            foreach (var emp in empList)
            {
                if (emp.DOJ < date2015)
                {
                    joinedBefore2015.Add(emp);
                }
            }
            Console.WriteLine("Employees who joined before 1/1/2015:");
            foreach (var emp in joinedBefore2015)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}, {emp.Title}, {emp.City}");
            }
            Console.WriteLine();

            // 2. Display a list of all the employees whose date of birth is after 1/1/1990:
            List<Employee> dobAfter1990 = new List<Employee>();
            DateTime date1990 = new DateTime(1990, 1, 1);

            foreach (var emp in empList)
            {
                if (emp.DOB > date1990)
                {
                    dobAfter1990.Add(emp);
                }
            }
            Console.WriteLine("Employees born after 1/1/1990:");
            foreach (var emp in dobAfter1990)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}, {emp.Title}, {emp.City}");
            }
            Console.WriteLine();

            // 3. Display a list of all the employees whose designation is Consultant and Associate:
            List<Employee> consultantsAndAssociates = new List<Employee>();

            foreach (var emp in empList)
            {
                if (emp.Title == "Consultant" || emp.Title == "Associate")
                {
                    consultantsAndAssociates.Add(emp);
                }
            }
            Console.WriteLine("Consultants and Associates:");
            foreach (var emp in consultantsAndAssociates)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}, {emp.Title}, {emp.City}");
            }
            Console.WriteLine();

            // 4. Display the total number of employees:
            int totalEmployees = empList.Count;
            Console.WriteLine($"Total Employees: {totalEmployees}");
            Console.WriteLine();

            // 5. Display the total number of employees belonging to Chennai:
            int chennaiEmployees = 0;

            foreach (var emp in empList)
            {
                if (emp.City == "Chennai")
                {
                    chennaiEmployees++;
                }
            }
            Console.WriteLine($"Total Employees in Chennai: {chennaiEmployees}");
            Console.WriteLine();

            // 6. Display the highest employee ID from the list:
            int highestEmployeeID = empList[0].EmployeeID;

            foreach (var emp in empList)
            {
                if (emp.EmployeeID > highestEmployeeID)
                {
                    highestEmployeeID = emp.EmployeeID;
                }
            }
            Console.WriteLine($"Highest Employee ID: {highestEmployeeID}");
            Console.WriteLine();

            // 7. Display the total number of employees who have joined after 1/1/2015:
            int joinedAfter2015 = 0;
            DateTime dateAfter2015 = new DateTime(2015, 1, 1);

            foreach (var emp in empList)
            {
                if (emp.DOJ > dateAfter2015)
                {
                    joinedAfter2015++;
                }
            }
            Console.WriteLine($"Total Employees joined after 1/1/2015: {joinedAfter2015}");
            Console.WriteLine();

            // 8. Display the total number of employees whose designation is not Associate:
            int nonAssociates = 0;

            foreach (var emp in empList)
            {
                if (emp.Title != "Associate")
                {
                    nonAssociates++;
                }
            }
            Console.WriteLine($"Total Employees not Associate: {nonAssociates}");
            Console.WriteLine();

            // 9. Display the total number of employees based on the city:
            var employeesByCity = new Dictionary<string, int>();

            foreach (var emp in empList)
            {
                if (employeesByCity.ContainsKey(emp.City))
                {
                    employeesByCity[emp.City]++;
                }
                else
                {
                    employeesByCity[emp.City] = 1;
                }
            }
            Console.WriteLine("Total Employees by City:");
            foreach (var city in employeesByCity.Keys)
            {
                Console.WriteLine($"{city}: {employeesByCity[city]}");
            }
            Console.WriteLine();

            // 10. Display the total number of employees based on city and title:
            var employeesByCityAndTitle = new Dictionary<string, Dictionary<string, int>>();

            foreach (var emp in empList)
            {
                if (!employeesByCityAndTitle.ContainsKey(emp.City))
                {
                    employeesByCityAndTitle[emp.City] = new Dictionary<string, int>();
                }

                if (employeesByCityAndTitle[emp.City].ContainsKey(emp.Title))
                {
                    employeesByCityAndTitle[emp.City][emp.Title]++;
                }
                else
                {
                    employeesByCityAndTitle[emp.City][emp.Title] = 1;
                }
            }
            Console.WriteLine("Total Employees by City and Title:");
            foreach (var city in employeesByCityAndTitle.Keys)
            {
                foreach (var title in employeesByCityAndTitle[city].Keys)
                {
                    Console.WriteLine($"{city} - {title}: {employeesByCityAndTitle[city][title]}");
                }
            }
            Console.WriteLine();

            // 11. Display the employee who is the youngest in the list:
            Employee youngestEmployee = empList[0];

            foreach (var emp in empList)
            {
                if (emp.DOB > youngestEmployee.DOB)
                {
                    youngestEmployee = emp;
                }
            }
            Console.WriteLine("Youngest Employee:");
            Console.WriteLine($"{youngestEmployee.FirstName} {youngestEmployee.LastName}, {youngestEmployee.Title}, {youngestEmployee.City}, DOB: {youngestEmployee.DOB.ToShortDateString()}");

            Console.ReadKey();
        }
    }
}

