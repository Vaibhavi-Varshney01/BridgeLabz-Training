using System;
class EvenOdd {
    static void Main() {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number <= 0) {
            Console.WriteLine("Invalid input! Please enter a natural number.");
            return;
        }
        int size = number / 2 + 1;
        int[] odd = new int[size];
        int[] even = new int[size];
        int oddIndex = 0;
        int evenIndex = 0;
        for (int i = 1; i <= number; i++) {
            if (i % 2 == 0) {
                even[evenIndex] = i;
                evenIndex++;
            } else {
                odd[oddIndex] = i;
                oddIndex++;
            }
        }
        Console.WriteLine("\nOdd Numbers:");
        for (int i = 0; i < oddIndex; i++) {
            Console.Write(odd[i] + " ");
        }
        Console.WriteLine("\n\nEven Numbers:");
        for (int i = 0; i < evenIndex; i++) {
            Console.Write(even[i] + " ");
        }
    }
}
