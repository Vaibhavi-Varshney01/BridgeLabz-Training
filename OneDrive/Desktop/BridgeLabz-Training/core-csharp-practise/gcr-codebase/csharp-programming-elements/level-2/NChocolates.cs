using System;

public class NChocolates {
    public static void Main(String[] args) {

        Console.WriteLine("Enter total number of chocolates:");
        int numberOfChocolates = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter total number of children:");
        int numberOfChildren = int.Parse(Console.ReadLine());

        int chocolatesEach = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        Console.WriteLine("The number of chocolates each child gets is "
                          + chocolatesEach +
                          " and the number of remaining chocolates is "
                          + remainingChocolates);
    }
}
