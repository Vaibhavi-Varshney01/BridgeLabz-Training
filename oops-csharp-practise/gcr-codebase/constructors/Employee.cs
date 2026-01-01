using System;
class Employee{
    public int employeeID;
    protected string department;
    private double salary;
    public void SetSalary(double amount){
        salary = amount;
    }
    public double GetSalary(){
        return salary;
    }
}
class Manager : Employee{
    public void ShowDetails(){
        Console.WriteLine($"ID: {employeeID}, Department: {department}");
    }
}
