using System;
class Trigonometric{
    public static double[] CalculateTrigonometricFunctions(double angle){
        double rad = angle * Math.PI / 180;
        return new double[]
        {
            Math.Sin(rad),
            Math.Cos(rad),
            Math.Tan(rad)
        };
    }
    static void Main(){
        Console.Write("Enter angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());
        double[] res = CalculateTrigonometricFunctions(angle);
        Console.WriteLine("Sin: " + res[0]);
        Console.WriteLine("Cos: " + res[1]);
        Console.WriteLine("Tan: " + res[2]);
    }
}
