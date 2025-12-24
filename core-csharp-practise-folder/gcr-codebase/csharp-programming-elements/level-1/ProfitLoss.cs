using System;
public class ProfitLoss{
  public static void Main(String [] args){
    int cp = 129;
    int sp = 191;
    int profit = sp - cp;
    int profitPercentage = profit/cp*100;
    Console.WriteLine("The Cost Price is INR " + cp + " and selling Price is INR " + sp + "The Profit is INR" + profit + " and the profit percent is " + profitPercentage);
  }
}