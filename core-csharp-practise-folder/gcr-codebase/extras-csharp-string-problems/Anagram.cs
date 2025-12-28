using System;
class Anagram{
    static void Main(){
        string s1 = "listen";
        string s2 = "silent";
        if (s1.Length != s2.Length){
            Console.WriteLine("Not Anagrams");
            return;
        }
        int[] freq = new int[256];
        for (int i = 0; i < s1.Length; i++){
            freq[s1[i]]++;
            freq[s2[i]]--;
        }
        foreach (int x in freq){
            if (x != 0){
                Console.WriteLine("Not Anagrams");
                return;
            }
        }
        Console.WriteLine("Strings are Anagrams");
    }
}
