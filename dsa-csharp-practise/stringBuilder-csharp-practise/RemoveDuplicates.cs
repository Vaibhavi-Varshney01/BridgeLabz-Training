using System;
using System.Text;
class RemoveDuplicates{
    static void Main(){
        string input = "programming";
        StringBuilder result = new StringBuilder();
        foreach (char ch in input){
            if (result.ToString().IndexOf(ch) == -1){
                result.Append(ch);
            }
        }

        Console.WriteLine("After Removing Duplicates: " + result);
    }
}
