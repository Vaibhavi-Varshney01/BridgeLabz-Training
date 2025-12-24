using System;
class SumOfNaturalNumbers{
    static void Main(string[] args){
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0){
            Console.WriteLine("Please enter a natural number (greater than 0).");
        }
        else{
            int sumWhile = 0;
            int i = 1;
            while (i <= n){
                sumWhile += i;
                i++;
            }
            int sumFormula = n * (n + 1) / 2;
            Console.WriteLine("Sum using while loop: " + sumWhile);
            Console.WriteLine("Sum using formula: " + sumFormula);
            if (sumWhile == sumFormula){
                Console.WriteLine("Result is correct! Both computations are equal.");
            }
            else{
                Console.WriteLine("Result is incorrect! Computations do not match.");
            }
        }
    }
}
