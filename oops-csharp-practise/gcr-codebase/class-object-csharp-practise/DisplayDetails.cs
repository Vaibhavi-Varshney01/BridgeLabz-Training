using System;
class Details{
  public string name;
  public int id;
  public float salary;

  public void Display(){
    Console.WriteLine("Name of the Employee: " + name);
    Console.WriteLine("ID of the Employee: " + id);
    Console.WriteLine("Salary of the Employees: " + salary);
  }
}
  class DisplayDetails{
  static void Main(){
    Details emp1 = new Details();
    emp1.name = "Vaibhavi";
    emp1.id = 31;
    emp1.salary = 50000.00f;
    emp1.Display();
  }
}
