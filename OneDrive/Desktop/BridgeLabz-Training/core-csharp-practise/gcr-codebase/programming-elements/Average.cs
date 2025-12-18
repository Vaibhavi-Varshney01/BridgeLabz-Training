using System;
public class Average{
  public static void Main(String [] args){
    Console.WriteLine("Enter num1 : ");
    int num1 = int.parse(Console.ReadLine());
    Console.WriteLine("Enter num2: ");
    int num2 = int.parse(Console.ReadLine());
    Console.WriteLine("Enter num3: ");
    int num3 = int.parse(Console.ReadLine());
    int avg = (num1 + num2 + num3)/3;
    Console.WriteLine(avg);
  }
}