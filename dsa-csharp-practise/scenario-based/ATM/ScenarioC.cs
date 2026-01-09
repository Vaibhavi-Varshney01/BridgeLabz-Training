using System;
class ScenarioC : ATMScenario
{
    public override void Execute()
    {
        Console.WriteLine("\nScenario C (Fallback Case): ₹250");

        int[] notes = { 200, 100 };
        ATM atm = new ATM(notes);
        atm.Dispense(250);
    }
}
