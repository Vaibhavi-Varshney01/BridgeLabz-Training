using System;
class UntilZero2{
    static void Main(){
        double sum = 0.0;
        double number;
        while (true){
            Console.Write("Enter a number (0 or negative to stop): ");
            number = Convert.ToDouble(Console.ReadLine());
            if (number <= 0){
                break;
            }
            sum += number;
        }
        Console.WriteLine("Sum of entered numbers = " + sum);
    }
}
