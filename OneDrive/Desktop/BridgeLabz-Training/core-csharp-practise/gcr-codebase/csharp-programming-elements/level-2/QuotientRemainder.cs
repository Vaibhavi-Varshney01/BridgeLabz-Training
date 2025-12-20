using System;
public class QuotientRemainder{
  public static void Main(String [] args){
    Console.WriteLine("Enter the number 1: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the number 2: ");
    int num2 = int.Parse(Console.ReadLine());
    int q = num1/num2;
    int rem = num1 % num2;
    Console.WriteLine("The Quotient is " + q + " and the Remainder is " + rem + " of two numbers.");
  }
}