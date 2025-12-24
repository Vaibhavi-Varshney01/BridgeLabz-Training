using System;
class LeapYear{
  public static void Main(String [] args){
    Console.WriteLine("Enter the number: ");
    int year = int.Parse(Console.ReadLine());
    if(year % 4 == 0 && year % 100 == 0){
      Console.WriteLine("Leap Year");
    }
    else{
      Console.WriteLine("Not a Leap Year");
    }
  }
}