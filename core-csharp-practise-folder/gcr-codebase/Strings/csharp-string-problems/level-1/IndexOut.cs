using System;
class IndexOut{
  static void Main(){
    IndexOutOfBound();
  }
  static void IndexOutOfBound(){
    try{
      string str = "Hello";
      Console.WriteLine(str[10]);
    }
    catch (IndexOutOfRangeException e){
      Console.WriteLine("IndexOutOfRangeException caught for string!");
      Console.WriteLine(e.Message);
    }
  }
}