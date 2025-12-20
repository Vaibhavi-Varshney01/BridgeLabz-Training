using System;
public class IntOperation{
  public static void Main(String [] args){
    Console.WriteLine("Enter the value of a: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the value of b: ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the value of c: ");
    int c = int.Parse(Console.ReadLine());
    int op1 = a+b*c;
    int op2 = a*b+c;
    int op3 = c+a/b;
    int op4 = a%b+c;
    Console.WriteLine("The results of Int Operations are " + op1 + "," + op2 + "," + op3 + "," + op4);
  }
}