using System;
class Palindrome{
  static void Main(){
    Console.WriteLine("Enter the String: ");
    string s = Console.ReadLine();
    string rev = "";
    for(int i = s.Length - 1; i>=0; i--){
      rev += s[i];
    }
    if(s.Equals(rev)){
      Console.WriteLine("String is Palindrome ");
    }
    else{
      Console.WriteLine("Not a Palindrome ");
    }
  }
}