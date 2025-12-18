using System;
public class Add{
  public static void Main(String [] args){
    Console.WriteLine("Enter the number");
    int num1 = int.parse(Console.ReadLine());
    int num2 = int.parse(Console.ReadLine());
    int sum = num1 + num2;
    Console.WriteLine("Sum of two numbers is: " + sum);
  }
}