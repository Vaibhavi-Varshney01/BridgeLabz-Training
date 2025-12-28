using System;
class MostFrequent{
    static void Main(){
        string s = "success";
        int maxCount = 0;
        char maxChar = s[0];
        for (int i = 0; i < s.Length; i++){
            int count = 1;
            for (int j = i + 1; j < s.Length; j++){
                if (s[i] == s[j])
                    count++;
            }
            if (count > maxCount){
                maxCount = count;
                maxChar = s[i];
            }
        }
        Console.WriteLine("Most Frequent Character: '" + maxChar + "'");
    }
}
