using System;
class QuotientRemainder{
    public static int[] FindRemainderAndQuotient(int number, int divisor){
        int quotient = number / divisor;
        int remainder = number % divisor;
        return new int[] { quotient, remainder };
    }
    static void Main(){
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter divisor: ");
        int div = int.Parse(Console.ReadLine());
        int[] res = FindRemainderAndQuotient(num, div);
        Console.WriteLine("Quotient: " + res[0]);
        Console.WriteLine("Remainder: " + res[1]);
    }
}
