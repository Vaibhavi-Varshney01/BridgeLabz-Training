using System;
class SumOfDigits{
    static int[] GetDigits(int num){
        char[] c = num.ToString().ToCharArray();
        int[] d = new int[c.Length];
        for (int i = 0; i < c.Length; i++)
            d[i] = c[i] - '0';
        return d;
    }
    static int SumOfDigits(int[] d){
        int sum = 0;
        foreach (int x in d) sum += x;
        return sum;
    }
    static double SumOfSquares(int[] d){
        double sum = 0;
        foreach (int x in d)
            sum += Math.Pow(x, 2);
        return sum;
    }
    static bool IsHarshad(int num, int[] d){
        return num % SumOfDigits(d) == 0;
    }
    static int[,] DigitFrequency(int[] d){
        int[,] freq = new int[10, 2];
        for (int i = 0; i < 10; i++) freq[i, 0] = i;
        foreach (int x in d)
            freq[x, 1]++;
        return freq;
    }
    static void Main(){
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        int[] digits = GetDigits(num);
        Console.WriteLine("Sum of digits: " + SumOfDigits(digits));
        Console.WriteLine("Sum of squares: " + SumOfSquares(digits));
        Console.WriteLine("Harshad Number: " + IsHarshad(num, digits));
        int[,] freq = DigitFrequency(digits);
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++)
            if (freq[i, 1] > 0)
                Console.WriteLine($"{freq[i, 0]} → {freq[i, 1]}");
    }
}
