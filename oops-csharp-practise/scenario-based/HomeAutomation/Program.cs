using System;
namespace HomeAutomation{
  class Program{
    static void Main(){
      IControllable device1 = new Light("Bedroom");
      IControllable device2 = new Fan("Living Room");
      IControllable device3 = new AC("Office");

      device1.TurnOn();
      device2.TurnOn();
      device3.TurnOn();
      
      Console.WriteLine();

      device1.TurnOff();
      device2.TurnOff();
      device3.TurnOff();
    }
  }
}