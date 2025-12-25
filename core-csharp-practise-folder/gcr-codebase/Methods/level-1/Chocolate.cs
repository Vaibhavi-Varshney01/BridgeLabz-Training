using System;
class Chocolate{
    static int[] FindRemainderAndQuotient(int chocolates, int children){
        return new int[] { chocolates / children, chocolates % children };
    }
    static void Main(){
        Console.Write("Enter chocolates: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Enter children: ");
        int ch = int.Parse(Console.ReadLine());
        int[] res = FindRemainderAndQuotient(c, ch);
        Console.WriteLine("Each child gets: " + res[0]);
        Console.WriteLine("Remaining chocolates: " + res[1]);
    }
}
