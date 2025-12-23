using System;
class SumOfNaturalNumbers2{
    static void Main(string[] args){
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0){
            Console.WriteLine("Please enter a natural number (greater than 0).");
        }
        else{
            int sumForLoop = 0;
            for (int i = 1; i <= n; i++){
                sumForLoop += i;
            }
            int sumFormula = n * (n + 1) / 2;
            Console.WriteLine("Sum using for loop: " + sumForLoop);
            Console.WriteLine("Sum using formula: " + sumFormula);
            if (sumForLoop == sumFormula){
                Console.WriteLine("Result is correct! Both results are equal.");
            }
            else{
                Console.WriteLine("Result is incorrect! Results do not match.");
            }
        }
    }
}
