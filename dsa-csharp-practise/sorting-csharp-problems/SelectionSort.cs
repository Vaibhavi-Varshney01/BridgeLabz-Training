using System;
class SelectionSortExample{
    static void Main(){
        int[] scores = { 78, 45, 90, 32 };
        for (int i = 0; i < scores.Length - 1; i++){
            int min = i;
            for (int j = i + 1; j < scores.Length; j++){
                if (scores[j] < scores[min])
                    min = j;
            }
            int temp = scores[min];
            scores[min] = scores[i];
            scores[i] = temp;
        }
        Console.WriteLine("Sorted Scores:");
        foreach (int s in scores)
            Console.Write(s + " ");
    }
}
