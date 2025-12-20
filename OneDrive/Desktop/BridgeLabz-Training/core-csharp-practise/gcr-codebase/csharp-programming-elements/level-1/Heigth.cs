using System;
public class Height{
  public static void Main(String [] args){
    Console.Writeline(" Enter the height in cm: ");
    double height = double.Parse(Console.ReadLine());
    double heightinfeets = height / 30.48;
    double inches = heightinfeets * 12;
    Console.WriteLine("Your height in cm is " + height + " while in feet is " + heightinfeets);
  }
}