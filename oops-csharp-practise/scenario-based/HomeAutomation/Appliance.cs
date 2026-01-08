using System;
namespace HomeAutomation{
  abstract class Appliance : IControllable{
    public string Name;
    public Appliance(string name){
      Name = name;
    }
    public abstract void TurnOn();
    public abstract void TurnOff();
  }
}