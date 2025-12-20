using System;
public class TotalIncome{
  public static void Main(String [] args){
    Console.WriteLine("Enter the salary: ");
    int salary = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the bonus: ");
    int bonus = int.Parse(Console.ReadLine());
    int income = salary + bonus;
    Console.WriteLine("The salary is INR " + " salary " + salary + "and bons is INR " + bonus + "Hence total income is INR " + income);
  }
}