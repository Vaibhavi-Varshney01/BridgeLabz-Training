using System;
class PosNeg{
  static void Main(){
    int n = 5;
    int [] arr = new int[n];
    for(int i = 0; i<n; i++){
      arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    for(int j = 0; j<n; j++){
      if(arr[j] > 0){
        if(arr[j] % 2 == 0){
          Console.WriteLine("The number " + arr[j] + " is positive and even");
        }
        else{
          Console.WriteLine("The number " + arr[j] + " is positive and odd");
        }
      }
      else if(arr[j] < 0){
        Console.WriteLine("The number " + arr[j] + " is negative");
      }
      else{
        Console.WriteLine("The number is zero");
      }
    }
    if(arr[0] == arr[n-1]){
      Console.WriteLine("Both the elements are equal");
    }
    else if(arr[0] > arr[n-1]){
      Console.WriteLine("First element is greater");
    }
    else if(arr[0] < arr[n-1]){
      Console.WriteLine("Last element is greater");
    }
  }
}