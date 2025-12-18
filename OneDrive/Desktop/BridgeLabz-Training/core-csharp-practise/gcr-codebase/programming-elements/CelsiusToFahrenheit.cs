using System;
public class CelsiusToFahrenheit{
  public static void Main(String [] args){
    Console.WriteLine("Enter the celsius: ");
    float celsius = float.parse(Console.ReadLine());
    float fahren = (celsius*9/5) + 32;
    Console.WriteLine(fahren);
  }
}