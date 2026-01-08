using System;
namespace HomeAutomation{
  class Light : Appliance{
    public Light(string name) : base(name){

    }
    public override void TurnOn(){
      Console.WriteLine(Name + " Light is ON!");
    }
    public override void TurnOff(){
      Console.WriteLine(Name + " Light is OFF!");
    }
  }
}