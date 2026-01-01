using System;
class Circle{
  public int radius;

  public Circle(int radius){
    this.radius = radius;
  }

  public Circle() : this(0){

  }
}
class CircleClass{
  static void Main(){
    Circle c1 = new Circle(10);
    Console.WriteLine("Radius of circle is: " + radius);

    Circle c2 = new Circle(5);
    Console.WriteLine("Radius of circle is: " + radius);
  }
}