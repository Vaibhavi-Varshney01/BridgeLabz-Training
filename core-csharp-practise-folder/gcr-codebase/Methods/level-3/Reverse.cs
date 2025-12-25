using System;
class NumberChecker{
    static int[] GetDigits(int num){
        char[] c = num.ToString().ToCharArray();
        int[] d = new int[c.Length];
        for (int i = 0; i < c.Length; i++)
            d[i] = c[i] - '0';
        return d;
    }
    static int[] ReverseArray(int[] arr){
        int[] rev = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
            rev[i] = arr[arr.Length - 1 - i];
        return rev;
    }
    static bool AreArraysEqual(int[] a, int[] b){
        for (int i = 0; i < a.Length; i++)
            if (a[i] != b[i]) return false;
        return true;
    }
    static bool IsPalindrome(int[] digits){
        return AreArraysEqual(digits, ReverseArray(digits));
    }
    static bool IsDuck(int[] digits){
        foreach (int d in digits)
            if (d != 0) return true;
        return false;
    }
    static void Main(){
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        int[] digits = GetDigits(num);
        Console.WriteLine("Palindrome: " + IsPalindrome(digits));
        Console.WriteLine("Duck Numbers: " + IsDuck(digits));
    }
}
