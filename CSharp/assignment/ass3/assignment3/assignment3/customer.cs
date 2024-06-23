using System;

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Phone { get; set; }
    public string City { get; set; }

    
    public Customer()
    {
    }

   
    public Customer(int id, string name, int age, string phone, string city)
    {
        CustomerId = id;
        Name = name;
        Age = age;
        Phone = phone;
        City = city;
    }

    
    public static void DisplayCustomer(Customer customer)
    {
        Console.WriteLine("Customer ID: " + customer.CustomerId);
        Console.WriteLine("Name: " + customer.Name);
        Console.WriteLine("Age: " + customer.Age);
        Console.WriteLine("Phone: " + customer.Phone);
        Console.WriteLine("City: " + customer.City);
    }

    
    ~Customer()
    {
        Console.WriteLine("Customer object destroyed.");
    }
}

class Progcustomer
{
    static void Main(string[] args)
    {

        Customer customer1 = new Customer();
        Customer.DisplayCustomer(customer1);


        Customer customer2 = new Customer(1, "sri", 03, "9994344812", "erode");
        Customer.DisplayCustomer(customer2);
    }
}