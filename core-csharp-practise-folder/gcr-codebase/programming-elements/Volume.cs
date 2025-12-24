using System;
public class Volume{
  public static void Main(String [] args){
    Console.WriteLine("Enter the height: ");
    int h = int.parse(Console.ReadLine());
    Console.WriteLine("Enter the radius: ");
    int r = int.parse(Console.ReadLine());
    double vol = 3.14*r*r*h;
    Console.WriteLine(vol);
  }
}