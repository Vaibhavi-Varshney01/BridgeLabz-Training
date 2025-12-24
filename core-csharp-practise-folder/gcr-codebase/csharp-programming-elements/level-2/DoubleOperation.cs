using System;
public class DoubleOperation{
  public static void Main(String [] args){
    Console.WriteLine("Enter the value of a: ");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter the value of b: ");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter the value of c: ");
    double c = double.Parse(Console.ReadLine());
    double op1 = a+b*c;
    double op2 = a*b+c;
    double op3 = c+a/b;
    double op4 = a%b+c;
    Console.WriteLine("The results of Int Operations are " + op1 + "," + op2 + "," + op3 + "," + op4);
  }
}