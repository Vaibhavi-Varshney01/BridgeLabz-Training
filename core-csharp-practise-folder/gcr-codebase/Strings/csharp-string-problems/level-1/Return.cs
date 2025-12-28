using System;
class Return{
  static void Main(){
    Console.WriteLine("Enter the string: ");
    string str = Console.ReadLine();
    char ret = returnChar(str);
    Console.WriteLine("Characters of string are: " + ret);
  }
  static char returnChar(string s){
    for(int i = 0; i<s.Length; i++){
      return s[i];
    }
    return '\0';
  }
}