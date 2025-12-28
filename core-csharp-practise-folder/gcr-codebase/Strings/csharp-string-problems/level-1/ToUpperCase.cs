using System;
class ToUpperCase{
  static void Main(){
    Console.WriteLine("Enter the String: ");
    string str = Console.ReadLine();
    string up = ToUpper(str);
    Console.WriteLine("String in Upper case: " + up);
  }
  static string ToUpper(string s){
    string up = s.ToUpper();
    return up;
  }
}