using System;
class Program{
    static void Main(string[] args){
        Employee emp1 = new FullTimeEmployee(50000);
        emp1.EmployeeId = 101;
        emp1.Name = "Rahul";
        ((IDepartment)emp1).AssignDepartment("IT");

        Employee emp2 = new PartTimeEmployee(40);
        emp2.EmployeeId = 102;
        emp2.Name = "Anjali";
        ((IDepartment)emp2).AssignDepartment("HR");

        emp1.DisplayDetails();
        emp2.DisplayDetails();

        Console.ReadLine();
    }
}
