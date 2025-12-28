using System;
class NumberGuessing{
    static void Main(){
        PlayGame();
    }
    static void PlayGame(){
        int low = 1, high = 100;
        string feedback = "";
        Console.WriteLine("Think of a number between 1 and 100");
        while (feedback != "correct"){
            int guess = GenerateGuess(low, high);
            Console.WriteLine("Computer guess: " + guess);
            Console.WriteLine("Is it high, low or correct?");
            feedback = Console.ReadLine().ToLower();
            if (feedback == "high")
                high = guess - 1;
            else if (feedback == "low")
                low = guess + 1;
        }
        Console.WriteLine("Computer guessed it!");
    }
    static int GenerateGuess(int low, int high)
    {
        return (low + high) / 2;
    }
}
