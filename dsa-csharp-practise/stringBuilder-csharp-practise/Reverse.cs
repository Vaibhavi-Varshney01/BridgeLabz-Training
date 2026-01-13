using System;
using System.Text;
class Reverse {
    static void Main(){
        string input = "hello";
        StringBuilder sb = new StringBuilder(input);

        int start = 0;
        int end = sb.Length - 1;

        while (start < end){
            char temp = sb[start];
            sb[start] = sb[end];
            sb[end] = temp;
            start++;
            end--;
        }
        Console.WriteLine("Reversed String: " + sb.ToString());
    }
}
