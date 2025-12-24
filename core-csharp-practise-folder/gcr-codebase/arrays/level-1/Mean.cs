using System;
class Mean{
  static void Main(){
    int n = 11;
    Console.WriteLine("Enter the array: ");
    double [] heights = new double[n];
    for(int i = 0; i<n; i++){
      heights[i] = double.Parse(Console.ReadLine());
    }
    double mean = 0.0;
    double sum = 0.0;
    for(int i = 0; i<n; i++){
      sum = sum + heights[i];
    }
    mean = sum/heights.Length;
    Console.WriteLine(mean);
  }
}