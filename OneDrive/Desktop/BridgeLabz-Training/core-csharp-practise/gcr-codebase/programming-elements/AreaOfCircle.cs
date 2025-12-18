using System;
pulbic class AreaOfCircle{
  public static void Main(String [] args){
    Console.WriteLine("Enter the radius: ");
    int r = int.parse(Console.ReadLine());
    double area = 3.14*r*r;
    Console.WriteLine("Area of the circle is: " + area);
  }
}