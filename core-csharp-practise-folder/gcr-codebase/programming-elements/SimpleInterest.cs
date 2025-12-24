using System;
public class SimpleInterest{
  public static void Main(String [] args){
    Console.WriteLine("Enter the Principal: ");
    int p = int.parse(Console.ReadLine());
    Console.WriteLine("Enter the rate: ");
    int r = int.parse(Console.ReadLine());
    Console.WriteLine("Enter the time: ");
    int t = int.parse(Console.ReadLine());
    int si = (p*r*t)/100;
    Console.WriteLine(si);
  }
}