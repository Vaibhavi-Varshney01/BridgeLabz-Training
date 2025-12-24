using System;
class BMI {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        double[] weight = new double[n];
        double[] height = new double[n];
        double[] bmi = new double[n];
        string[] status = new string[n];
        for (int i = 0; i < n; i++) {
            weight[i] = double.Parse(Console.ReadLine());
            height[i] = double.Parse(Console.ReadLine());
            bmi[i] = weight[i] / (height[i] * height[i]);
            if (bmi[i] < 18.5) status[i] = "Underweight";
            else if (bmi[i] < 25) status[i] = "Normal";
            else status[i] = "Overweight";
        }
        for (int i = 0; i < n; i++)
            Console.WriteLine(height[i] + " " + weight[i] + " " + bmi[i] + " " + status[i]);
    }
}
