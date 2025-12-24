using System;
public class Swapping{
  public static void Main(String [] args){
    Console.WriteLine("Enter number 1: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter number 2: ");
    int num2 = int.Parse(Console.ReadLine());
    int temp = num1;
    num1 = num2;
    num2 = temp;
    Console.WriteLine("The swapped numbers are " + num1 + " and " + num2);
  }
}