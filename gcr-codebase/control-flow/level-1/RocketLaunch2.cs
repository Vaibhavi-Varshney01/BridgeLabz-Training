using System;
public class RocketLaunch2{
  public static void Main(String [] args){
    Console.WriteLine("Enter the countdown: ");
    int cd = int.Parse(Console.ReadLine());
    for(int i = cd; i>=1; i--){
      Console.WriteLine(i);
    }
  }
}