using System;
class Multi{
    static void Main(){
        int[] arr = new int[4];
        Console.WriteLine("Enter 4 numbers:");
        for(int i = 0; i < arr.Length; i++){
            arr[i] = int.Parse(Console.ReadLine());
        }
        for(int i = 0; i < arr.Length; i++){
            for(int j = 6; j <= 9; j++){
                Console.WriteLine(arr[i] + " * " + j + " = " + (arr[i] * j));
            }
            Console.WriteLine(); 
        }
    }
}
