using System;
public class Discount{
  public static void Main(String [] args){
    int fee = 125000;
    int discountPercent = 10;
    double discount = fee * (discountPercent/100.0);
    double payFee = fee - discount;
    Console.WriteLine("The discount amount is INR "+ discount + " and final discounted fee is INR " + payFee);
  }
}