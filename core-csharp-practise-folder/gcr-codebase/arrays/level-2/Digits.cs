using System;
class Digits {
    static void Main() {
        int num = int.Parse(Console.ReadLine());
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;
        while (num != 0 && index < maxDigit) {
            digits[index++] = num % 10;
            num /= 10;
        }
        int largest = 0, second = 0;
        for (int i = 0; i < index; i++) {
            if (digits[i] > largest) {
                second = largest;
                largest = digits[i];
            } else if (digits[i] > second && digits[i] != largest) {
                second = digits[i];
            }
        }
        Console.WriteLine("Largest = " + largest);
        Console.WriteLine("Second Largest = " + second);
    }
}
