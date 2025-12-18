using System;

class ValidAnagram
{
    static void Main()
    {
        string str1 = "listen";
        string str2 = "silent";

        if (str1.Length != str2.Length)
        {
            Console.WriteLine("Not a Valid Anagram");
            return;
        }

        int[] count = new int[26];

        for (int i = 0; i < str1.Length; i++)
        {
            count[str1[i] - 'a']++;
            count[str2[i] - 'a']--;
        }

        bool isAnagram = true;

        for (int i = 0; i < 26; i++)
        {
            if (count[i] != 0)
            {
                isAnagram = false;
                break;
            }
        }

        if (isAnagram)
            Console.WriteLine("Valid Anagram");
        else
            Console.WriteLine("Not a Valid Anagram");
    }
}
