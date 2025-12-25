using System;
class NumberCheck{
    static int CheckNumber(int num){
        if (num > 0) return 1;
        else if (num < 0) return -1;
        else return 0;
    }
    static void Main(){
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Result: " + CheckNumber(num));
    }
}
