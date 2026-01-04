using System;
class Bank{
static string bankName;
static int totalAccounts;
static string accountHolder;
readonly int accountNumber;
double balance;

public Bank(string bankName , string accountHolder,int accountNumber, double balance){
  this.bankName = bankName;
  this.accountHolder = accountHolder;
  this.accountNumber = this.accountNumber;
  this.balance = balance;
  totalAccounts++;
}
public static void GetTotalAccounts(){
  Console.WriteLine($"Total Accounts in {bankName} : {totalAccounts}");
}
public static void DisplayDetails(){
    Console.WriteLine($"Bank: {bankName}");
    Console.WriteLine($"Account Holder: {AccountHolderName}");
    Console.WriteLine($"Account Number: {AccountNumber}");
    Console.WriteLine($"Balance: {Balance}\n");
  }
}
class Program{
    static void Main(){
        BankAccount acc1 = new BankAccount("Vaibhavi", 101, 5000);
        BankAccount acc2 = new BankAccount("Rohan", 102, 10000);

        if (acc1 is BankAccount)
            acc1.DisplayDetails();
        if (acc2 is BankAccount)
            acc2.DisplayDetails();
        BankAccount.GetTotalAccounts();
    }
}
