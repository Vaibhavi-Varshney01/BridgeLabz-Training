using System;
class Friends{
    static int FindYoungest(int[] ages){
        int min = ages[0];
        foreach (int a in ages)
            if (a < min) min = a;
        return min;
    }
    static double FindTallest(double[] heights){
        double max = heights[0];
        foreach (double h in heights)
            if (h > max) max = h;
        return max;
    }
    static void Main(){
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];
        for (int i = 0; i < 3; i++){
            Console.Write($"Enter age of {names[i]}: ");
            ages[i] = int.Parse(Console.ReadLine());
            Console.Write($"Enter height of {names[i]}: ");
            heights[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Youngest Age: " + FindYoungest(ages));
        Console.WriteLine("Tallest Height: " + FindTallest(heights));
    }
}
