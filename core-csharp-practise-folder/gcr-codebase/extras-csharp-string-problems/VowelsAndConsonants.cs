using System;
class VowelsAndConsonants{
  static void Main(){
    Console.WriteLine("Enter the string: ");
    string str = Console.ReadLine();
    int v = 0;
    int c = 0;
    for(int i = 0; i<str.Length; i++){
      if(str.charAt(i) == 'A' || str.charAt(i) == 'E' || str.charAt(i) == 'I' || str.charAt(i) == 'O' || str.charAt(i) == 'U' || str.charAt(i) == 'a' || str.charAt(i) == 'e' || str.charAt(i) == 'i' || str.charAt(i) == 'o' || str.charAt(i) == 'u'){
        v++;
      }
      else{
        c++;
      }
    }
    Console.WriteLine("Number of vowels are: " + v + " and number of consonants are: " + c);
  }
}