using System;
class FurnitureRevenueCalculator{
    // Scenario A: Max revenue
    public int CalculateMaxRevenue(WoodenRod rod){
        int n = rod.GetLength();
        int[] price = rod.GetPrices();
        int maxRevenue = price[n - 1];
        for (int i = 1; i < n; i++){
            int revenue = price[i - 1] + price[n - i - 1];
            if (revenue > maxRevenue)
                maxRevenue = revenue;
        }
        return maxRevenue;
    }
    // Scenario B: Fixed waste constraint
    public int CalculateWithWasteLimit(WoodenRod rod, int maxWaste){
        int n = rod.GetLength();
        int[] price = rod.GetPrices();
        int maxRevenue = 0;
        for (int i = 1; i <= n; i++){
            int waste = n - i;
            if (waste <= maxWaste){
                int revenue = price[i - 1];
                if (revenue > maxRevenue)
                    maxRevenue = revenue;
            }
        }
        return maxRevenue;
    }
    // Scenario C: Max revenue + min waste
    public int CalculateRevenueWithMinWaste(WoodenRod rod){
        int n = rod.GetLength();
        int[] price = rod.GetPrices();

        int bestRevenue = 0;
        int minWaste = n;

        for (int i = 1; i <= n; i++){
            int revenue = price[i - 1];
            int waste = n - i;

            if (revenue > bestRevenue ||
               (revenue == bestRevenue && waste < minWaste)){
                bestRevenue = revenue;
                minWaste = waste;
            }
        }
        return bestRevenue;
    }
}
