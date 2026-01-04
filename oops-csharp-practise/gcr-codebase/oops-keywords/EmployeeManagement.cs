using System;
class Employee{
  public static string companyName = "ABC Technologies Pvt. Ltd.";
  public static int totalEmployees = 0;

  public string employeeName;
  public readonly int ID;
  public string designation;

  public Employee(string employeeName, int ID, string designation){
    this.employeeName = employeeName;
    this.ID = ID;
    this.designation = designation;
    totalEmployees++;
  }

  public static void DisplayTotalEmployees(){
    Console.WriteLine("Total number of employees: " + totalEmployees);
  }

public void DisplayEmployees(){
  Console.WriteLine($"Name: {employeeName}, ID: {ID}, Designation: {designation}");
}
}
class EmployeeManagement{
  static void Main(){
    Employee e1 = new Employee("Vaibhavi Varshney" , 101, "Developer");
    Employee e2 = new Employee("Arnav", 102, "Tester");
    Employee.DisplayTotalEmployees();

    object obj = e1;
    if(obj is Employee){
      Employee emp = (Employee)obj;
      emp.DisplayEmployees();
    }
  }
}