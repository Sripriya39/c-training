using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public int ProductId 
    { 
        get;
        set; 
    }
    public string ProductName 
    { 
        get;
        set;
    }
    public decimal Price
    {
        get;
        set;
    }
}

class SortingProducts
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Enter product details:");
            Console.WriteLine("---------------");
            Console.Write("Product ID: ");
            int productId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Product Name: ");
            string productName = Console.ReadLine();
            Console.Write("Price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Product product = new Product
            { 
                ProductId = productId, ProductName = productName, Price = price
            };

            products.Add(product);
        }

        products = products.OrderBy(p => p.Price).ToList();

        Console.WriteLine("Sorted Products:");
        foreach (var product in products)
        {
            Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price}");
        }
    }
}