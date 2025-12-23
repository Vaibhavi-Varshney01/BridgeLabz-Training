using System;
public class RocketLaunch{
  public static void Main(String [] args){
    Console.WriteLine("Enter the countdown: ");
    int cd = int.Parse(Console.ReadLine());
    while(cd != 0){
      Console.WriteLine(cd);
      cd--;
    }
  }
}