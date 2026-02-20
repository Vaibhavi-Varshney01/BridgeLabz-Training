using System;
class EduQuiz{
    static string[] correctAnswers = {
        "A","B","C","D","A","C","B","D","A","B"
    };
    static void Main(){
        int role;
        int choice;

        Console.WriteLine("------ EduQuiz System ------");
        Console.WriteLine("Select Role:");
        Console.WriteLine("1. Admin");
        Console.WriteLine("2. Student");
        role = Convert.ToInt32(Console.ReadLine());

        switch (role){
            case 1:
                Console.Write("Enter Admin Password: ");
                string password = Console.ReadLine();

                if (password != "admin123")
                {
                    Console.WriteLine("Wrong Password! Access Denied.");
                    break;
                }

                Console.WriteLine("\nAdmin Logged In");
                Console.WriteLine("Correct Answers:");
                for (int i = 0; i < correctAnswers.Length; i++)
                {
                    Console.WriteLine("Q" + (i + 1) + ": " + correctAnswers[i]);
                }
                break;

            case 2:
                string[] studentAnswers = new string[10];

                Console.WriteLine("\nStudent Quiz Started");
                for (int i = 0; i < studentAnswers.Length; i++)
                {
                    Console.Write("Enter answer for Question " + (i + 1) + ": ");
                    studentAnswers[i] = Console.ReadLine();
                }

                int score = CalculateScore(correctAnswers, studentAnswers);
                double percentage = (score / 10.0) * 100;

                Console.WriteLine("\nTotal Score: " + score + "/10");
                Console.WriteLine("Percentage: " + percentage + "%");

                if (percentage >= 40)
                    Console.WriteLine("Result: PASS ");
                else
                    Console.WriteLine("Result: FAIL ");
                break;

            default:
                Console.WriteLine("Invalid Role Selected");
                break;
        }
    }
    static int CalculateScore(string[] correct, string[] student)
    {
        int score = 0;

        for (int i = 0; i < correct.Length; i++)
        {
            if (correct[i].Equals(student[i], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Question " + (i + 1) + ": Correct");
                score++;
            }
            else
            {
                Console.WriteLine("Question " + (i + 1) + ": Incorrect");
            }
        }
        return score;
    }
}
