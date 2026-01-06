class Program
{
    static void Main(string[] args)
    {
        Patient p1 = new InPatient(101, "Rahul", 30, 5, 2000);
        Patient p2 = new OutPatient(102, "Anita", 25, 500);

        p1.DisplayInfo();
        Console.WriteLine();

        p2.DisplayInfo();
        Console.WriteLine();

        Bill bill = new Bill();
        bill.GenerateBill((IPayable)p1);
        bill.GenerateBill((IPayable)p2);
    }
}
