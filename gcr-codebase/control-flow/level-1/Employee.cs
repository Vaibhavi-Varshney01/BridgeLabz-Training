using System;
class Employee{
    static void Main(string[] args){
        Console.Write("Enter Salary: ");
        double salary = double.Parse(Console.ReadLine());
        Console.Write("Enter Years of Service: ");
        int years = int.Parse(Console.ReadLine());
        if (years > 5){
            double bonus = salary * 0.05;
            Console.WriteLine("Bonus Amount: " + bonus);
        }
        else{
            Console.WriteLine("No bonus. Service period is less than or equal to 5 years.");
        }
    }
}
