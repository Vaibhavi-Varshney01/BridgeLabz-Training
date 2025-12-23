using System;
class BMI{
    static void Main(){
        Console.Write("Enter weight (kg): ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Enter height (cm): ");
        double heightCm = double.Parse(Console.ReadLine());
        double heightM = heightCm / 100;
        double bmi = weight / (heightM * heightM);
        Console.WriteLine("BMI: " + bmi);
        if (bmi < 18.5)
            Console.WriteLine("Underweight");
        else if (bmi < 25)
            Console.WriteLine("Normal");
        else if (bmi < 30)
            Console.WriteLine("Overweight");
        else
            Console.WriteLine("Obese");
    }
}
