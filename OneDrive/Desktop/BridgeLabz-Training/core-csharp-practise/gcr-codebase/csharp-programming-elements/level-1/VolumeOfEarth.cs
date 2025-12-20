using System;
public class VolumeOfEarth{
  public static void Main(String [] args){
    int r = 6378;
    double volume = (4/3)*3.14*(r*r*r);
    double inMiles = r*0.621371;
    Console.WriteLine("The volume of earth in cubic kilometers is " + volume + " and cubic miles is " + inMiles);
  }
}