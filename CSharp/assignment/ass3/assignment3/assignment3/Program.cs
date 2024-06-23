using System;

public class Accounts
{
    private int accountNo;
    private string customerName;
    private string accountType;
    private double balance;

    public Accounts(int accountNo, string customerName, string accountType)
    {
        this.accountNo = accountNo;
        this.customerName = customerName;
        this.accountType = accountType;
        this.balance = 0.0;
    }

    public void PerformTransaction(char transactionType, double amount)
    {
        if (transactionType == 'D' || transactionType == 'd')
        {
            Credit(amount);
        }
        else if (transactionType == 'W' || transactionType == 'w')
        {
            Debit(amount);
        }
        else
        {
            Console.WriteLine("Invalid transaction type. Please enter 'D' for deposit or 'W' for withdrawal.");
        }
    }

    private void Credit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance is {balance}.");
    }

    private void Debit(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn {amount}. New balance is {balance}.");
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }

    public void ShowData()
    {
        Console.WriteLine($"Account No: {accountNo}");
        Console.WriteLine($"Customer Name: {customerName}");
        Console.WriteLine($"Account Type: {accountType}");
        Console.WriteLine($"Balance: {balance}");
    }
}

public class account
{
    public static void Main(string[] args)
    {
        Console.Write("Enter account number: ");
        int accountNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter customer name: ");
        string customerName = Console.ReadLine();

        Console.Write("Enter account type: ");
        string accountType = Console.ReadLine();

        Accounts account = new Accounts(accountNo, customerName, accountType);

        while (true)
        {
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show account information");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter amount to deposit: ");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    account.PerformTransaction('D', depositAmount);
                    break;
                case 2:
                    Console.Write("Enter amount to withdraw: ");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    account.PerformTransaction('W', withdrawAmount);
                    break;
                case 3:
                    account.ShowData();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }
        }
    }
}