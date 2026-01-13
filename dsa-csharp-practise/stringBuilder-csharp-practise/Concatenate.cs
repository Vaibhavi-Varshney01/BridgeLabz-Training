using System;
using System.Text;
class Concatenate {
    static void Main(){
        string[] words = { "Hello", " ", "World", " ", "C#", " ", "Rocks!" };
        StringBuilder sb = new StringBuilder();
        foreach (string word in words)
        {
            sb.Append(word);
        }
        Console.WriteLine("Concatenated String: " + sb.ToString());
    }
}
