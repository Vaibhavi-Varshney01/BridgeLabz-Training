using System;
class Remove{
    static void Main(){
        Console.WriteLine("Enter the String: ");
        string s = Console.ReadLine();
        string result = "";
        for (int i = 0; i < s.Length; i++){
            bool isDuplicate = false;
            for (int j = 0; j < result.Length; j++){
                if (s[i] == result[j]){
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate){
                result += s[i];
            }
        }
        Console.WriteLine("String after removing duplicates: " + result);
    }
}
