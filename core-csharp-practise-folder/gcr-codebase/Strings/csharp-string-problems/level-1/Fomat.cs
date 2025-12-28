using System;
class Format{
  static void Main(){
    DemonstrateFormatException();
  }
  static void DemonstrateFormatException(){
    try{
      string str = "abc123";
      int num = int.Parse(str);
    }
    catch(FormatException e){
      Console.WriteLine("Format Exception caught");
      Console.WriteLine(e.Message);
    }
  }
}