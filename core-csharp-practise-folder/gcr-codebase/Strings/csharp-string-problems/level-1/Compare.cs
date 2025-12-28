using System;
class Compare{
  static void Main(){
    Console.WriteLine("Enter the String: ");
    string str1 = Console.ReadLine();
    string str2 = Console.ReadLine();
    bool compare = compareString(str1, str2);
    bool built = str1.Equals(str2);
    Console.WriteLine("Custom Comparison: " + compare);
    Console.WriteLine("Built-in Comparison: " + built);
  }
  static bool compareString(string s1, string s2){
     if(s1.Length != s2.Length){
        return false;
      }
    for(int i = 0; i<s1.Length; i++){
      if(s1[i] != s2[i]){
        return false;
      }
    }
    return true;
  }
}