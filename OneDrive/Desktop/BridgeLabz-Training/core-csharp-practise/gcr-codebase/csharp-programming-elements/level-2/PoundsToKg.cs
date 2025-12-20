using System;

public class poundsToKg {
    public static void Main(String[] args) {

        Console.WriteLine("Enter weight in pounds:");
        double weightInPounds = double.Parse(Console.ReadLine());

        double weightInKg = weightInPounds / 2.2;

        Console.WriteLine("The weight of the person in pounds is " 
                          + weightInPounds + 
                          " and in kg is " + weightInKg);
    }
}
