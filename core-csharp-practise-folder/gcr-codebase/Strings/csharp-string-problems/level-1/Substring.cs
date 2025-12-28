using System;
class Substring{
  static void Main(){
    Console.WriteLine("Enter the string: ");
    string str = Console.ReadLine();
    Console.WriteLine("Enter the index: ");
    int idx = int.Parse(Console.ReadLine());
    string sub = subString(str, idx);
    Console.WriteLine("Substring of " + str + " till index " + idx + 
    " is: " + sub);
  }
  static string substring(string str, int idx){
    string sub = str.substring(idx);
    return sub;
  }
}