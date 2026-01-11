using System;
class CountingSort{
    static void Main(){
        int[] ages = { 12, 15, 10, 14, 12, 18 };
        int max = 18;
        int min = 10;

        int[] count = new int[max - min + 1];

        for (int i = 0; i < ages.Length; i++)
            count[ages[i] - min]++;

        Console.WriteLine("Sorted Ages:");
        for (int i = 0; i < count.Length; i++)
        {
            while (count[i] > 0)
            {
                Console.Write((i + min) + " ");
                count[i]--;
            }
        }
    }
}
