using System;
public class AreaOfTriangle{
  public static void Main(String [] args){
    Console.WriteLine("Enter the base: ");
    int base = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the Height: ");
    int height = int.Parse(Console.ReadLine());
    int area = (1/2)*(base*height);
    Console.WriteLine("Area ofTriangle is " + area);
  }
}