using System;
class Program{
    static void Main(){
        int[] prices = { 2, 5, 7, 8, 10, 13, 17, 18, 20, 24, 25, 30 };
        WoodenRod rod = new WoodenRod(12, prices);
        FurnitureRevenueCalculator calculator = new FurnitureRevenueCalculator();
        ResultPrinter printer = new ResultPrinter();

        int scenarioA = calculator.CalculateMaxRevenue(rod);
        int scenarioB = calculator.CalculateWithWasteLimit(rod, 2);
        int scenarioC = calculator.CalculateRevenueWithMinWaste(rod);

        printer.Print("Scenario A - Max Revenue: ", scenarioA);
        printer.Print("Scenario B - Revenue with Waste Constraint: ", scenarioB);
        printer.Print("Scenario C - Revenue with Min Waste: ", scenarioC);
    }
}
