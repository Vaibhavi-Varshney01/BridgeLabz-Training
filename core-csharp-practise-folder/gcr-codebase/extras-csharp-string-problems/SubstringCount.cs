using System;
class SubstringCount{
    static void Main(){
        Console.WriteLine("Enter the string:");
        string s = Console.ReadLine();
        Console.WriteLine("Enter the substring:");
        string sub = Console.ReadLine();
        int count = 0;
        for (int i = 0; i <= s.Length - sub.Length; i++){
            int j;
            for (j = 0; j < sub.Length; j++){
                if (s[i + j] != sub[j])
                    break;
            }
            if (j == sub.Length)
                count++;
        }
        Console.WriteLine("Occurrences: " + count);
    }
}
