using System;
class Handshakes{
    static int CalculateHandshakes(int n){
        return (n * (n - 1)) / 2;
    }
    static void Main(){
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Maximum handshakes: " + CalculateHandshakes(n));
    }
}
