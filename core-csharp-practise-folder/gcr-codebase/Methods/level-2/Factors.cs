using System;
class Factors{
    static int[] FindFactors(int num){
        int count = 0;
        for (int i = 1; i <= num; i++){
            if (num % i == 0) 
            count++;
        }
        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= num; i++){
            if (num % i == 0)
                factors[index++] = i;
        }
        return factors;
    }
    static int SumOfFactors(int[] arr){
        int sum = 0;
        foreach (int x in arr) sum += x;
        return sum;
    }
    static long ProductOfFactors(int[] arr){
        long product = 1;
        foreach (int x in arr) product *= x;
        return product;
    }
    static double SumOfSquares(int[] arr){
        double sum = 0;
        foreach (int x in arr){
            sum += Math.Pow(x, 2);
        }
        return sum;
    }
    static void Main(){
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        int[] factors = FindFactors(num);
        Console.WriteLine("Factors:");
        foreach (int f in factors){
            Console.Write(f + " ");
        }
        Console.WriteLine("\nSum = " + SumOfFactors(factors));
        Console.WriteLine("Product = " + ProductOfFactors(factors));
        Console.WriteLine("Sum of Squares = " + SumOfSquares(factors));
    }
}
