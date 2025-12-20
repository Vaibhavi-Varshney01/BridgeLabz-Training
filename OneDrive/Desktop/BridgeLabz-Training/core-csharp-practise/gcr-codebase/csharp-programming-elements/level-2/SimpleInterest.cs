using System;

public class SimpleInterest {
    public static void Main(String[] args) {

        Console.WriteLine("Enter Principal amount:");
        double principal = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Rate of Interest:");
        double rate = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Time (in years):");
        double time = double.Parse(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100;

        Console.WriteLine("The Simple Interest is " + simpleInterest +
                          " for Principal " + principal +
                          ", Rate of Interest " + rate +
                          " and Time " + time);
    }
}
