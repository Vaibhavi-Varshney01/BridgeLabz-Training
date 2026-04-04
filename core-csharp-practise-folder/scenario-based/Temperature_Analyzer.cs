using System;

class TemperatureAnalyzer
{
    static void Main()
    {
        float[,] temperatures = new float[7, 24]
        {
            {30,31,32,33,34,35,36,35,34,33,32,31,30,29,28,27,26,25,24,25,26,27,28,29},
            {28,29,30,31,32,33,34,35,36,37,36,35,34,33,32,31,30,29,28,27,26,25,24,23},
            {25,26,27,28,29,30,31,32,33,34,33,32,31,30,29,28,27,26,25,24,23,22,21,20},
            {32,33,34,35,36,37,38,39,40,39,38,37,36,35,34,33,32,31,30,29,28,27,26,25},
            {20,21,22,23,24,25,26,27,28,29,28,27,26,25,24,23,22,21,20,19,18,17,16,15},
            {27,28,29,30,31,32,33,34,35,36,35,34,33,32,31,30,29,28,27,26,25,24,23,22},
            {35,36,37,38,39,40,41,42,43,42,41,40,39,38,37,36,35,34,33,32,31,30,29,28}
        };

        AnalyzeTemperature(temperatures);
    }

    static void AnalyzeTemperature(float[,] temp)
    {
        float hottestAvg = float.MinValue;
        float coldestAvg = float.MaxValue;
        int hottestDay = 0, coldestDay = 0;

        for (int i = 0; i < 7; i++)
        {
            float sum = 0;

            for (int j = 0; j < 24; j++)
            {
                sum += temp[i, j];
            }

            float avg = sum / 24;
            Console.WriteLine("Average temperature of Day " + (i + 1) + ": " + avg);

            if (avg > hottestAvg)
            {
                hottestAvg = avg;
                hottestDay = i + 1;
            }

            if (avg < coldestAvg)
            {
                coldestAvg = avg;
                coldestDay = i + 1;
            }
        }

        Console.WriteLine("\nHottest Day: Day " + hottestDay);
        Console.WriteLine("Coldest Day: Day " + coldestDay);
    }
}
