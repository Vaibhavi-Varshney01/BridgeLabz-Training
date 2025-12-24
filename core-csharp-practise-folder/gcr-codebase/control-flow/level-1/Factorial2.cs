using System;
class Factorial2{
    static void Main(string[] args){
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        if (num <= 0){
            Console.WriteLine("Please enter a natural number.");
        }
        else{
            int fact = 1;
            for (int i = 1; i <= num; i++){
                fact *= i;
            }
            Console.WriteLine("Factorial of " + num + " is: " + fact);
        }
    }
}
