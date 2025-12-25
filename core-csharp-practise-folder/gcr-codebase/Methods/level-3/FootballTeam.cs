using System;
class FootballTeam{
    static int Sum(int[] arr){
        int s = 0;
        foreach (int x in arr) s += x;
        return s;
    }
    static double Mean(int[] arr) => (double)Sum(arr) / arr.Length;
    static int Shortest(int[] arr){
        int min = arr[0];
        foreach (int x in arr) if (x < min) min = x;
        return min;
    }
    static int Tallest(int[] arr){
        int max = arr[0];
        foreach (int x in arr) if (x > max) max = x;
        return max;
    }
    static void Main(){
        int[] heights = new int[11];
        Random r = new Random();
        for (int i = 0; i < 11; i++)
            heights[i] = r.Next(150, 251);
        Console.WriteLine("Shortest: " + Shortest(heights));
        Console.WriteLine("Tallest: " + Tallest(heights));
        Console.WriteLine("Mean: " + Mean(heights));
    }
}
