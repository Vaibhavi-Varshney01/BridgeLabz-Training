using System;
public class NaturalNumbers{
  public static void Main(String [] args){
    Console.WriteLine("Enter the number: ");
    int num = int.Parse(Console.ReadLine());
    if(num != 0 && num > 0){
      Console.WriteLine("Natural Number!");
    }
    else{
      Console.WriteLine("Not a Natural Number!")
    }
    int sum = num*(num + 1) / 2;
    Console.WriteLine("Sum of natural number is: " + sum);
  }
}
