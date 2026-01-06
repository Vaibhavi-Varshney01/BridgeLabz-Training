public class Bill
{
    public void GenerateBill(IPayable payable)
    {
        Console.WriteLine($"Final Amount to Pay: ₹{payable.CalculateBill()}");
    }
}
