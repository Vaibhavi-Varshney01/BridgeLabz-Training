using System;
class ArguementOut{
  static void Main(){
    DemonstrateArgumentOutOfRange();
  }
  static void DemonstrateArgumentOutOfRange(){
    try{
      string str = "Hello World!";
      string sub = str.Substring(8,10);
    }
    catch (ArgumentOutOfRangeException e){
      Console.WriteLine("ArgumentOutOfRangeException caught!");
      Console.WriteLine(e.Message);
    }
  }
}