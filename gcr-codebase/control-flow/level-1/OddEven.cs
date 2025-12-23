using System;
class OddEven{
    static void Main(string[] args){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number <= 0){
            Console.WriteLine("Please enter a natural number.");
        }
        else{
            for (int i = 1; i <= number; i++){
                if (i % 2 == 0){
                    Console.WriteLine(i + " is Even");
                }
                else{
                    Console.WriteLine(i + " is Odd");
                }
            }
        }
    }
}
