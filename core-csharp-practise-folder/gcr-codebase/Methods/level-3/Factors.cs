using System;
class Factors{
    static int[] GetFactors(int n){
        int count = 0;
        for (int i = 1; i <= n; i++)
            if (n % i == 0) count++;
        int[] f = new int[count];
        int idx = 0;
        for (int i = 1; i <= n; i++)
            if (n % i == 0) f[idx++] = i;
        return f;
    }
    static int Sum(int[] arr){
        int s = 0;
        foreach (int x in arr) s += x;
        return s;
    }
    static bool IsPerfect(int n){
        int sum = 0;
        for (int i = 1; i < n; i++)
            if (n % i == 0) sum += i;
        return sum == n;
    }
    static bool IsAbundant(int n){
        int sum = 0;
        for (int i = 1; i < n; i++)
            if (n % i == 0) sum += i;
        return sum > n;
    }
    static bool IsDeficient(int n){
        int sum = 0;
        for (int i = 1; i < n; i++)
            if (n % i == 0) sum += i;
        return sum < n;
    }
    static int Factorial(int n){
        int f = 1;
        for (int i = 1; i <= n; i++) f *= i;
        return f;
    }
    static bool IsStrong(int n){
        int temp = n, sum = 0;
        while (temp > 0){
            sum += Factorial(temp % 10);
            temp /= 10;
        }
        return sum == n;
    }
    static void Main(){
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Perfect: " + IsPerfect(n));
        Console.WriteLine("Abundant: " + IsAbundant(n));
        Console.WriteLine("Deficient: " + IsDeficient(n));
        Console.WriteLine("Strong: " + IsStrong(n));
    }
}
