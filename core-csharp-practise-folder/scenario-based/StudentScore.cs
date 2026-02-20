using System;
class StudentScore{
  static void Main(){
    
  }
}using System;

class StudentScores
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter score of student " + (i + 1) + ": ");
                    int score = Convert.ToInt32(Console.ReadLine());

                    if (score < 0)
                    {
                        Console.WriteLine("Score cannot be negative!");
                        continue;
                    }

                    scores[i] = score;
                    sum += score;
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                }
            }
        }

        double average = sum / (double)n;

        int max = scores[0];
        int min = scores[0];

        for (int i = 1; i < n; i++)
        {
            if (scores[i] > max)
                max = scores[i];
            if (scores[i] < min)
                min = scores[i];
        }

        Console.WriteLine("\nAverage Score: " + average);
        Console.WriteLine("Highest Score: " + max);
        Console.WriteLine("Lowest Score: " + min);

        Console.WriteLine("Scores above average:");
        for (int i = 0; i < n; i++)
        {
            if (scores[i] > average)
                Console.WriteLine(scores[i]);
        }
    }
}
