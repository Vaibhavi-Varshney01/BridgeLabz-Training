using System;
public class Conversion{
  public static void Main(String [] args){
    Console.WriteLine("Enter the distance in Km: ");
    double km = double.Parse(Console.ReadLine());
    double miles = km/1.6;
    Console.WriteLine("The total miles is " + miles + " mile for the givem " + km + " km");
  }
}