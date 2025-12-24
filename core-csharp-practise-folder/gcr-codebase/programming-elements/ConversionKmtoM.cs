using System;
public class ConversionKmToM{
  public static void Main(String[] args){
    Console.WriteLine("Enter the KM: ");
    float km = float.parse(Console.ReadLine());
    float miles = km*(0.62137119);
    Console.WriteLine(miles);
  }
}