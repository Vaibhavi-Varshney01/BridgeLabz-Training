using System;
public class UserDiscount{
  public static void Main(String [] args){
    Console.WriteLine("Enter the Fee: ");
    double fee = double.Parse(Console.ReadLine());
    double discountPercent = double.Parse(Console.ReadLine());
    double discount = fee * (discountPercent/100.0);
    Console.WriteLine("The discount amount is INR " + discount + " and the final discounted fee is INR " + fee - discount);
  }
}