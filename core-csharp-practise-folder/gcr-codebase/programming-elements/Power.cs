using System;
public class Power{
  public static void Main(String [] args){
    Console.WriteLine("Enter the base: ");
    double b = double.parse(Console.ReadLine());
    Console.WriteLine("Enter the Exponent: ");
    double e = double.parse(Console.ReadLine());
    double p = Math.pow(b,e);
    Console.WriteLine(p);
  }
}