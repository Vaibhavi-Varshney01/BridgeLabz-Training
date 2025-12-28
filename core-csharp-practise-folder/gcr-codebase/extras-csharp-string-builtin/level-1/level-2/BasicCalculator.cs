using System;
class Calculator{
    static void Main(){
        Console.WriteLine("Enter two numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("1.Add  2.Sub  3.Mul  4.Div");
        int choice = int.Parse(Console.ReadLine());
        switch (choice){
            case 1: Console.WriteLine(Add(a, b)); break;
            case 2: Console.WriteLine(Sub(a, b)); break;
            case 3: Console.WriteLine(Mul(a, b)); break;
            case 4: Console.WriteLine(Div(a, b)); break;
        }
    }
    static double Add(double a, double b) => a + b;
    static double Sub(double a, double b) => a - b;
    static double Mul(double a, double b) => a * b;
    static double Div(double a, double b) => a / b;
}
