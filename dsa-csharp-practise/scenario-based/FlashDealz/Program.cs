using System;
using FlashDealz;

class Program
{
    static void Main()
    {
        int[] discounts = { 30, 70, 20, 90, 50, 10 };
        QuickSorting.QuickSort(discounts, 0, discounts.Length - 1);
        QuickSorting.Display(discounts);
    }
}
