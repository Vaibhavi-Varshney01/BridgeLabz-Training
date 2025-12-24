using System;
class UntilZero{
    static void Main(){
        double sum = 0.0;
        double inputValue = 1;
        while (inputValue != 0){
            Console.Write("Enter a number (press 0 to end): ");
            inputValue = Convert.ToDouble(Console.ReadLine());
            sum += inputValue;
        }
        Console.WriteLine("Final Sum = " + sum);
    }
}
