using System;

class BankAccount
{
    private int balance;
    
    public BankAccount(int initBal)
    {
        balance = initBal;
    }
    
    public void Deposit(int amount)
    {
        if(amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount}. Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Should be positive amount");
        }
    }
    
    public void Withdraw(int amount)
    {
        if(amount > 0)
        {
            if(balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount}. Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }
        else
        {
            Console.WriteLine("Should be positive amount");
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount ba = new BankAccount(0);
        ba.Deposit(500);
        ba.Withdraw(200);
        ba.Withdraw(1000);
    }
}
