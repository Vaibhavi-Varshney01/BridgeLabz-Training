using System;
public class Largest{
  public static void Main(String [] args){
    Console.WriteLine("Enter the number1: ");
    int a = int.Parse(Console.ReadLine());
     Console.WriteLine("Enter the number2: ");
    int b = int.Parse(Console.ReadLine());
     Console.WriteLine("Enter the number3: ");
    int c = int.Parse(Console.ReadLine());
    bool flag = false;
    if(a > b && a > c){
      flag = true;
      Console.WriteLine("Is the first number the largest ? " + flag);
    }
    else if(b > a && b > c){
      flag = true;
      Console.WriteLine("Is the second number the largest ? " + flag);
    }
    else if(c > a && c > b){
      flag = true;
      Console.WriteLine("Is the third number the largest ? " + flag);
    }
    Console.WriteLine("Is the first number the largest ? " + flag);
  }
}