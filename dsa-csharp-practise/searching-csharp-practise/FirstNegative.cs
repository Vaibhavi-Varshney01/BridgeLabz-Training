using System;
class FirstNegative{
    static void Main(){
        int[] arr = { 4, 6, 2, -3, 8, -1 };
        for (int i = 0; i < arr.Length; i++){
            if (arr[i] < 0){
                Console.WriteLine("First Negative Number: " + arr[i]);
                return;
            }
        }
        Console.WriteLine("No negative number found");
    }
}
