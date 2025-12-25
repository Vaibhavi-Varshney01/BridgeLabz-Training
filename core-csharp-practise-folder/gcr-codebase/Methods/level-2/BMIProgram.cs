using System;
class BMIProgram{
    static void CalculateBMI(double[,] data){
        for (int i = 0; i < 10; i++){
            double heightMeter = data[i, 1] / 100;
            data[i, 2] = data[i, 0] / (heightMeter * heightMeter);
        }
    }
    static string GetBMIStatus(double bmi){
        if (bmi < 18.5) return "Underweight";
        if (bmi < 24.9) return "Normal";
        if (bmi < 29.9) return "Overweight";
        return "Obese";
    }
    static void Main(){
        double[,] data = new double[10, 3];
        for (int i = 0; i < 10; i++){
            Console.Write($"Enter weight of person {i + 1}: ");
            data[i, 0] = double.Parse(Console.ReadLine());
            Console.Write($"Enter height(cm) of person {i + 1}: ");
            data[i, 1] = double.Parse(Console.ReadLine());
        }
        CalculateBMI(data);
        Console.WriteLine("\nWeight\tHeight\tBMI\tStatus");
        for (int i = 0; i < 10; i++){
            Console.WriteLine($"{data[i,0]}\t{data[i,1]}\t{data[i,2]:0.00}\t{GetBMIStatus(data[i,2])}");
        }
    }
}
