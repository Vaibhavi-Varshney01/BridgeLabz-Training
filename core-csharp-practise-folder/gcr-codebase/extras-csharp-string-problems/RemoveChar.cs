using System;
class RemoveChar{
    static void Main(){
        string s = "Hello World";
        char remove = 'l';
        string result = "";
        for (int i = 0; i < s.Length; i++){
            if (s[i] != remove)
                result += s[i];
        }        Console.WriteLine("Modified String: " + result);
    }
}
