using System;
namespace HomeAutomation{
  class AC : Appliance{
    public AC(string name) : base(name){

    }
    public override void TurnOn(){
      Console.WriteLine(Name + " AC is On!");
    }
    public override void TurnOff(){
      Console.WriteLine(Name + " AC is Off!");
    }
  }
}