using System;
public class CanVote{
  public static void Main(String [] args){
    Console.WriteLine("Enter the age: ");
    int age = int.Parse(Console.ReadLine());
    if(age < 18){
      Console.WriteLine("The person cannot Vote.");
    }
    else{
      Console.WriteLine("The Person can Vote.");
    }
  }
}