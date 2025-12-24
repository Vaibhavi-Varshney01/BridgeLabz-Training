using System;
class Greatest{
    static void Main(){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int greatestFactor = 1;
        for (int i = number - 1; i >= 1; i--){
            if (number % i == 0){
                greatestFactor = i;
                break;
            }
        }
        Console.WriteLine("Greatest Factor: " + greatestFactor);
    }
}
