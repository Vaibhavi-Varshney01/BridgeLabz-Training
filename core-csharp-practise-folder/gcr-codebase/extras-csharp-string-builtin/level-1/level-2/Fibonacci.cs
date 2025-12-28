using System;
class Fibonacci{
    static void Main(){
        Console.WriteLine("Enter number of terms:");
        int n = int.Parse(Console.ReadLine());
        PrintFibonacci(n);
    }
    static void PrintFibonacci(int n){
        int a = 0, b = 1;
        for (int i = 1; i <= n; i++){
            Console.Write(a + " ");
            int next = a + b;
            a = b;
            b = next;
        }
    }
}
