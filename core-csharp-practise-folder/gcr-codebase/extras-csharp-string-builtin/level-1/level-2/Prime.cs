using System;
class Prime{
    static void Main(){
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n) ? "Prime" : "Not Prime");
    }
    static bool IsPrime(int n){
        if (n <= 1) return false;
        for (int i = 2; i <= n / 2; i++){
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
