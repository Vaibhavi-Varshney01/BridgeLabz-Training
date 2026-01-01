using System;
class BankAccount{
    public int accountNumber;
    protected string accountHolder;
    private double balance;
    public void SetBalance(double amount){
        balance = amount;
    }
    public double GetBalance(){
        return balance;
    }
}
class SavingsAccount : BankAccount{
    public void DisplayDetails(){
        Console.WriteLine($"Account No: {accountNumber}, Holder: {accountHolder}");
    }
}
