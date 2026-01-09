using System;
class ScenarioA : ATMScenario {
  public override void Execute(){
    Console.WriteLine("\n Scenario A : Rs. 880");
    int [] notes = {500, 200, 100, 50, 20, 10, 5, 2, 1};
    ATM atm = new ATM(notes);
    atm.Dispense(880);
  }
}