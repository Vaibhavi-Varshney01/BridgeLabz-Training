using System;
class Multiplication{
  static void Main(){
    Console.WriteLine("enter the number: ");
    int num = int.Parse(Console.ReadLine());
    int [] arr = new int[11];
    for(int i = 1; i<arr.Length; i++){
      arr[i] = num*i;
      Console.WriteLine(arr[i]);
    }

  }
}