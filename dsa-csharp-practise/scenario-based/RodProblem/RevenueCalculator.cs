using System;
class RevenueCalculator{
    public int CalculateMaxRevenue(Rod rod){
        int n = rod.GetLength();
        int[] price = rod.GetPrices();
        int maxRevenue = price[n - 1]; // no cut
        // One cut
        for (int i = 1; i < n; i++){
            int revenue = price[i - 1] + price[n - i - 1];
            if (revenue > maxRevenue)
                maxRevenue = revenue;
        }
        // Two cuts
        for (int i = 1; i < n; i++) {
            for (int j = 1; j < n; j++){
                int k = n - (i + j);
                if (k > 0){
                    int revenue = price[i - 1] + price[j - 1] + price[k - 1];
                    if (revenue > maxRevenue)
                        maxRevenue = revenue;
                }
            }
        }
        return maxRevenue;
    }
}
