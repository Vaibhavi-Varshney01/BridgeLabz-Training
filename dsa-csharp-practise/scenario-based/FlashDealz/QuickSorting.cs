using System;

namespace FlashDealz
{
    class QuickSorting
    {
        public static void QuickSort(int[] discounts, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(discounts, low, high);

                QuickSort(discounts, low, pivot - 1);
                QuickSort(discounts, pivot + 1, high);
            }
        }

        public static int Partition(int[] discounts, int low, int high)
        {
            int pivot = discounts[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (discounts[j] > pivot)
                {
                    i++;
                    int temp = discounts[i];
                    discounts[i] = discounts[j];
                    discounts[j] = temp;
                }
            }

            int swap = discounts[i + 1];
            discounts[i + 1] = discounts[high];
            discounts[high] = swap;

            return i + 1;
        }

        public static void Display(int[] discounts)
        {
            Console.WriteLine("Top Discounted Products:");
            for (int i = 0; i < discounts.Length; i++)
            {
                Console.WriteLine($"Rank {i + 1}: {discounts[i]}% off");
            }
        }
    }
}
