using System;
class ToLowercase(){
  static void Main(){
    Console.WriteLine("Enter the string: ");
    string str = Console.ReadLine();
    string toLower = ToLowerCase(str);
    Console.WriteLine("String in lower case: " + toLower);
  }
  static string ToLowerCase(string s){
    string str = s.ToLower();
    return str;
  }
}