class BankApp
{
    static void Main()
    {
        BankAccount account = new BankAccount(101, 5000);

        account.CheckBalance();
        account.Deposit(2000);
        account.Withdraw(1000);
        account.Withdraw(8000);   // overdraft case
        account.CheckBalance();
    }
}
