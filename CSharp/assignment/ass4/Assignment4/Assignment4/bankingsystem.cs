using System;

public class BankAccount
{
    private decimal _balance;

    public BankAccount(decimal initialBalance)
    {
        _balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive", nameof(amount));
        }
        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive", nameof(amount));
        }
        if (_balance < amount)
        {
            throw new InsufficientBalanceException("Insufficient balance in account");
        }
        _balance -= amount;
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}

public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message) { }
}

class BankingSystem
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(1000);

        try
        {
            account.Deposit(1500);
            Console.WriteLine("Balance: " + account.GetBalance());

            account.Withdraw(500);
            Console.WriteLine("Balance: " + account.GetBalance());

            account.Withdraw(1000); 
            Console.WriteLine("Balance: " + account.GetBalance());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}