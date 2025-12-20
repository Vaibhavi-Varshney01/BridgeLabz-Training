using System;
public class CtoF{
  public static void Main(String [] args){
    Console.WriteLine("Enter Fahrenheit: ");
    double f = double.Parse(Console.ReadLine());
    double c = (f-32)*5/9;
    Console.WriteLine("The " + f + " Fahrenheit is "+ c + " Celsius");
  }
}