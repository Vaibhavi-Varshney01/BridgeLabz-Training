using System;
class Festival{
    static void Main(){
        Console.Write("Enter number of visitors: ");
        int visitors = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= visitors; i++){
            Console.Write("Visitor " + i + ", enter your number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number <= 0){
                Console.WriteLine("Invalid number! Skipping...");
                continue;
            }
            if (number % 3 == 0 && number % 5 == 0){
                Console.WriteLine("🎉 Congratulations! You won a gift ");
            }
            else{
                Console.WriteLine("Sorry, better luck next time!");
            }
        }
    }
}
