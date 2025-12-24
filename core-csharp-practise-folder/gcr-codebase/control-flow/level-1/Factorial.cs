using System;
class Factorial{
    static void Main(string[] args){
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        if (num <= 0){
            Console.WriteLine("Please enter a positive integer.");
        }
        else{
            int fact = 1;
            int i = 1;
            while (i <= num){
                fact = fact * i;
                i++;
            }
            Console.WriteLine("Factorial of " + num + " is: " + fact);
        }
    }
}
