using System;
public class Smallest{
  public static void Main(String [] args){
    Console.WriteLine("Enter number1: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter number2: ");
    int num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter number3: ");
    int num3 = int.Parse(Console.ReadLine());
    bool flag = false;
    if(a < b && a < c){
      flag = true;
      Console.WriteLine("Is the first number is smallest ? " + flag);
    }
  }
}