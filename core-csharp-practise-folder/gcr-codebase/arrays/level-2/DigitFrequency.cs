using System;
class DigitFrequency {
    static void Main() {
        int num = int.Parse(Console.ReadLine());
        int[] freq = new int[10];
        while (num != 0) {
            int digit = num % 10;
            freq[digit]++;
            num /= 10;
        }
        for (int i = 0; i < 10; i++)
            Console.WriteLine(i + " → " + freq[i]);
    }
}
