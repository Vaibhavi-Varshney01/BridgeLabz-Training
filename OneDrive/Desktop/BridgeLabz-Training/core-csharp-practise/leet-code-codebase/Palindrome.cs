using System;
class Palindrome
{
    static void Main()
    {
        int num, ogNum, revNum = 0, r;

        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());

        ogNum = num;   

        while (num > 0)
        {
            r = num % 10;                  
            revNum = revNum * 10 + r;  
            num = num / 10;       
        }

        if (ogNum == reveNum)
        {
            Console.WriteLine("The number is a Palindrome.");
        }
        else
        {
            Console.WriteLine("The number is NOT a Palindrome.");
        }
    }
}
