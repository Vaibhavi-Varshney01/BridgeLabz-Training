using System;
class NumberChecker{
    public static int CountDigits(int n) => n.ToString().Length;
    public static int[] GetDigits(int n){
        char[] c = n.ToString().ToCharArray();
        int[] d = new int[c.Length];
        for (int i = 0; i < c.Length; i++)
            d[i] = c[i] - '0';
        return d;
    }
    public static bool IsDuck(int[] d){
        foreach (int x in d)
            if (x != 0) return true;
        return false;
    }
    public static bool IsArmstrong(int n, int[] d){
        int sum = 0, p = d.Length;
        foreach (int x in d)
            sum += (int)Math.Pow(x, p);
        return sum == n;
    }
    public static bool IsHarshad(int n, int[] d){
        int sum = 0;
        foreach (int x in d) sum += x;
        return n % sum == 0;
    }
    public static bool IsPalindrome(int[] d){
        int i = 0, j = d.Length - 1;
        while (i < j)
            if (d[i++] != d[j--]) return false;
        return true;
    }
    public static bool IsPrime(int n){
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }
    public static bool IsNeon(int n){
        int sq = n * n, sum = 0;
        while (sq > 0) { sum += sq % 10; sq /= 10; }
        return sum == n;
    }
    public static bool IsSpy(int[] d){
        int sum = 0, prod = 1;
        foreach (int x in d) { sum += x; prod *= x; }
        return sum == prod;
    }
    public static bool IsAutomorphic(int n)
        => (n * n).ToString().EndsWith(n.ToString());
    public static bool IsBuzz(int n)
        => n % 7 == 0 || n % 10 == 7;
}
