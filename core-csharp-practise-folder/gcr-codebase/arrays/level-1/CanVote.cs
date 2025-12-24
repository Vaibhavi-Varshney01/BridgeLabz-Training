using System;
class CanVote{
  public static void Main(string [] args){
    int n = 10;
    int [] arr = new int[n];
    for(int i = 0; i<n; i++){
      arr[i] = int.Parse(Console.ReadLine());
    }
    foreach(int j in arr){
      if(j < 0){
        Console.WriteLine("Invalid age");
      }
      else if(j >= 18){
        Console.WriteLine("The student with the age " + j + " can vote.");
      }
      else {
        Console.WriteLine("The student with the age " + j + " cannot vote.");
      }
    }
  }
}