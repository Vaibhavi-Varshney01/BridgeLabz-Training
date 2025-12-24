using System;
class Zara {
    static void Main() {
        int n = 10;
        double[] salary = new double[n];
        double[] years = new double[n];
        double[] bonus = new double[n];
        double[] newSalary = new double[n];
        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;
        for (int i = 0; i < n; i++) {
            Console.WriteLine($"Employee {i + 1}");
            Console.Write("Salary: ");
            salary[i] = double.Parse(Console.ReadLine());
            Console.Write("Years of Service: ");
            years[i] = double.Parse(Console.ReadLine());
            if (salary[i] <= 0 || years[i] < 0) {
                Console.WriteLine("Invalid input! Enter again.");
                i--;
                continue;
            }
        }
        for (int i = 0; i < n; i++) {
            if (years[i] > 5)
                bonus[i] = salary[i] * 0.05;
            else
                bonus[i] = salary[i] * 0.02;
            newSalary[i] = salary[i] + bonus[i];
            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];
        }
        Console.WriteLine("\nTotal Bonus = " + totalBonus);
        Console.WriteLine("Total Old Salary = " + totalOldSalary);
        Console.WriteLine("Total New Salary = " + totalNewSalary);
    }
}
