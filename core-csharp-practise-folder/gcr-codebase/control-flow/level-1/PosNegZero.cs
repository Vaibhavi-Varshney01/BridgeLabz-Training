using System;
public class PosNegZero{
  public static void Main(String [] args){
    Console.WriteLine("Enter the number: ");
    int num = int.Parse(Console.ReadLine());
    if(num > 0 && num !=0){
      Console.WriteLine("Positive");
    }
    else if(num < 0 && num != 0){
      Console.WriteLine("Negative");
    }
    else if(num == 0){
      Console.WriteLine("Zero");
    }
  }
}