using System;

public class Saledetails
{
    private int salesNo;
    private int productNo;
    private double price;
    private DateTime dateOfSale;
    private int qty;
    private double totalAmount;

    public Saledetails(int salesNo, int productNo, double price, DateTime dateOfSale, int qty)
    {
        this.salesNo = salesNo;
        this.productNo = productNo;
        this.price = price;
        this.dateOfSale = dateOfSale;
        this.qty = qty;
    }

    public void CalculateTotalAmount()
    {
        this.totalAmount = qty * price;
    }

    public void ShowData()
    {
        Console.WriteLine($"Sales No: {salesNo}");
        Console.WriteLine($"Product No: {productNo}");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Date of Sale: {dateOfSale}");
        Console.WriteLine($"Quantity: {qty}");
        Console.WriteLine($"Total Amount: {totalAmount}");
    }
}

public class saledetails
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Sales No: ");
        int salesNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Product No: ");
        int productNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Date of Sale (MM/dd/yyyy): ");
        DateTime dateOfSale = Convert.ToDateTime(Console.ReadLine());

        Console.Write("Enter Quantity: ");
        int qty = Convert.ToInt32(Console.ReadLine());

        Saledetails sale = new Saledetails(salesNo, productNo, price, dateOfSale, qty);
        sale.CalculateTotalAmount();
        sale.ShowData();

        Console.ReadLine();
    }
}