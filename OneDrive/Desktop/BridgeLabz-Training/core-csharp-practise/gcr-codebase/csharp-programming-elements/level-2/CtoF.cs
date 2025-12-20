using System;
public class CtoF{
  public static void Main(String [] args){
    Console.WriteLine("ENter celsius: ");
    double c = double.Parse(Console.ReadLine());
    double f = c*(9/5) + 32;
    Console.WriteLine("The " + c + " celsius is "+ f + " Fahrenheit");
  }
}