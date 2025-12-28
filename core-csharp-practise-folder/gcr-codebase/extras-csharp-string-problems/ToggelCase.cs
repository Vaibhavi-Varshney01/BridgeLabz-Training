using System;
class ToggleCase{
    static void Main(){
        Console.WriteLine("Enter string:");
        string s = Console.ReadLine();
        string result = "";
        for (int i = 0; i < s.Length; i++){
            if (s[i] >= 'A' && s[i] <= 'Z')
                result += (char)(s[i] + 32);
            else if (s[i] >= 'a' && s[i] <= 'z')
                result += (char)(s[i] - 32);
            else
                result += s[i];
        }
        Console.WriteLine("Toggled String: " + result);
    }
}
