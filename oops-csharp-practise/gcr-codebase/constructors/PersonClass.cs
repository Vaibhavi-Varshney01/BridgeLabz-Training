using System;
class Person{
  public string name;
  public int age;
  public string gender;

  public Person(string name, int age, string gender){
    this.name = name;
    this.age = age;
    this.gender = gender;
  }

  public Person(Person p1){
    this.name = p1.name;
    this.age = p1.age;
    this.gender = p1.gender;
  }

  public void Display(){
    Console.WriteLine("Name of Person: " + name);
    Console.WriteLine("Age of Person: " + age);
    Console.WriteLine("Person is: " + gender);
  }
}
class PersonClass{
  static void Main(){
    Person p1 = new Person("Vaibhavi",22,"female");
    Person p2 = new Person(p1);

    Console.WriteLine("Original Person: ");
    p1.Display();

    Console.WriteLine("Copied Person");
    p2.Display();
  }
}