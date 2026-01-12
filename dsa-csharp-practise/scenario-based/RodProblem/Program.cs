using System;
class Program{
    static void Main(){
        int[] prices = { 1, 5, 8, 9, 10, 17, 17, 20 };

        Rod rod = new Rod(8, prices);
        RevenueCalculator calculator = new RevenueCalculator();
        ResultPrinter printer = new ResultPrinter();

        int maxRevenue = calculator.CalculateMaxRevenue(rod);
        printer.Print(maxRevenue);
    }
}
