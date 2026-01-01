using System;
class BankAccount{
    // Fields
    public int AccountNumber;
    public double Balance;
    // Constructor
    public BankAccount(int accountNumber, double initialBalance){
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }
    // Method to deposit money
    public void Deposit(double amount){
        if (amount > 0){
            Balance += amount;
            Console.WriteLine($"Deposit Successful: {amount}");
        }
        else{
            Console.WriteLine("Deposit amount must be greater than zero.");
        }
    }
    public void Withdraw(double amount){
        if (amount <= 0){
            Console.WriteLine("Withdrawal amount must be greater than zero.");
        }
        else if (amount > Balance){
            Console.WriteLine("Insufficient balance! Overdraft not allowed.");
        }
        else{
            Balance -= amount;
            Console.WriteLine($"Withdrawal Successful: {amount}");
        }
    }
    // Method to check balance
    public void CheckBalance()
    {
        Console.WriteLine($"Current Balance: {Balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(101, 5000);

        account.CheckBalance();
        account.Deposit(2000);
        account.Withdraw(1000);
        account.Withdraw(7000); // overdraft attempt
        account.CheckBalance();
    }
}
