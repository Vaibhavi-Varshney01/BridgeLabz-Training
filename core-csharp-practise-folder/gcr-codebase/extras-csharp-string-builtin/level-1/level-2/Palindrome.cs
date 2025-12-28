using System;
class PalindromeCheck{
    static void Main(){
        string s = ReadString();
        Console.WriteLine(IsPalindrome(s) ? "Palindrome" : "Not Palindrome");
    }
    static string ReadString(){
        Console.WriteLine("Enter string:");
        return Console.ReadLine();
    }
    static bool IsPalindrome(string s){
        int start = 0, end = s.Length - 1;
        while (start < end){
            if (s[start] != s[end])
                return false;
            start++;
            end--;
        }
        return true;
    }
}
