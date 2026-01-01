using System;
class Circle{
  public int r;

  public void area(){
    double area = 3.14*r*r;
    Console.WriteLine("Area of the Circle is: " + area);
  }
  public void Circumference(){
    double circum = 2*3.14*r;
    Console.WriteLine("Perimetre of the circle is: " + circum);
  }
  public void Display(){
    Area();
    Circumference();
  }
}
class AreaOfCircle{
  static void Main(){
    Circle c1 = new Circle();
    c1.r = 2;
    c1.Display();
  }
}