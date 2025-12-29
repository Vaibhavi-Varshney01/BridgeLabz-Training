using System;
class Snake_ladders{
    static int[] positions = new int[4]; // maximum 4 players
    static string[] names = new string[4]; // name of the players
    static int playerCount;
    static Random ran = new Random(); // random function
    static void Main(){
        int choice;
        do{
            Console.WriteLine("WELCOME TO SNAKE AND LADDER GAME"); 
            Console.WriteLine("1. Start Game");// enables case 1
            Console.WriteLine("2. Exit"); // enables case 2
            Console.Write("Enter choice: "); // enter choice 1,2....
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice){
                case 1:
                    SetPlayers();
                    PlayGame();
                    break; // start game
                case 2:
                    Console.WriteLine("Goodbye!");
                    break; //end game
                default:
                    Console.WriteLine("Invalid choice!");
                    break; // when value is invalid
            } 
        } while (choice != 2); // run loop until choice != 2
    }
    static void SetPlayers(){
        Console.Write("Enter number of players: "); 
        playerCount = Convert.ToInt32(Console.ReadLine());// converts string into int
        if (playerCount < 2 || playerCount > 4){
            Console.WriteLine("Invalid number!");
        }
        for (int i = 0; i < playerCount; i++){
            positions[i] = 0; // initial position
            Console.WriteLine($"Enter Player {i + 1} Name: ");
            names[i] = Console.ReadLine();
            if (string.IsNullOrEmpty(names[i]))
                names[i] = "Player" + (i + 1);
        }
    }
    static void PlayGame(){
        bool win = false; 
        Console.WriteLine("Game Started!");
        while (!win){ // run the loop until a player wins
            for (int i = 0; i < playerCount; i++){
                Console.WriteLine($"{names[i]}'s turn");
                Console.ReadLine(); // input is enter to proceed next step
                int dice = RollDice();
                Console.WriteLine("Dice: " + dice);
                int oldPos = positions[i];
                int newPos = oldPos + dice; // updation of the position
                if (newPos > 100){
                    Console.WriteLine("Move skipped");
                    continue;
                }
                newPos = ApplySnakeOrLadder(newPos);
                positions[i] = newPos;
                Console.WriteLine($"Position: {oldPos} → {newPos}");
                if (CheckWin(newPos)){
                    Console.WriteLine($"{names[i]} WINS!");
                    win = true;
                    break;
                }
            }
        }
    }
    static int RollDice(){
        return ran.Next(1, 7); 
    }
    static int ApplySnakeOrLadder(int position){ // discussion of snake and ladders positions
        if (position == 4) {
            Console.WriteLine("Ladder Up!");
            return 14;
        }
        else if (position == 9) {
            Console.WriteLine("Ladder Up!");
            return 31;
        }
        else if (position == 17) {
            Console.WriteLine("Snake Down!");
            return 7;
        }
        else if (position == 20) {
            Console.WriteLine("Ladder Up!");
            return 38;
        }
        else if (position == 28) {
            Console.WriteLine("Ladder Up!");
            return 84;
        }
        else if (position == 40) {
            Console.WriteLine("Ladder Up!");
            return 59;
        }
        else if (position == 54) {
            Console.WriteLine("Snake Down!");
            return 34;
        }
        else if (position == 62) {
            Console.WriteLine("Snake Down!");
            return 19;
        }
        else if (position == 64) {
            Console.WriteLine("Snake Down!");
            return 60;
        }
        else if (position == 98) {
            Console.WriteLine("Snake Down!");
            return 79;
        }
        else {
            return position; 
        }
    }
    static bool CheckWin(int position) // winner declaration
    {
        return position == 100;
    }
}
