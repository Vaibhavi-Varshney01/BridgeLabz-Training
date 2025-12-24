using System;
public class SpringSeason{
  public static void Main(String [] args){
    Console.WriteLine("Enter the month: ");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the day: ");
    int d = int.Parse(Console.ReadLine());
    if(1 <= d =< 20 && 3 <= m =< 6 ){
      Console.WriteLine("It's a Spring Season")
    }
    else{
      Console.WriteLine("Not a Spring Season");
    }
  }
}