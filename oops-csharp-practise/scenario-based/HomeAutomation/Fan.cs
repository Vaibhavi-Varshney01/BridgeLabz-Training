using System;
namespace HomeAutomation{
  class Fan : Appliance{
    public Fan(string name) : base(name){

    }

    public override void TurnOn(){
      Console.WriteLine(Name + " Fan is On!");
    }
    public override void TurnOff(){
      Console.WriteLine(Name + " Fan is Off!");
    }
  }
}