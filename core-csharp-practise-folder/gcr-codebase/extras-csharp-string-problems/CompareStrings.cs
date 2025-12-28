using System;
class CompareStrings{
    static void Main(){
        string s1 = "apple";
        string s2 = "banana";
        int min = s1.Length < s2.Length ? s1.Length : s2.Length;
        int result = 0;
        for (int i = 0; i < min; i++){
            if (s1[i] != s2[i]){
                result = s1[i] - s2[i];
                break;
            }
        }
        if (result == 0)
            result = s1.Length - s2.Length;
        if (result < 0)
            Console.WriteLine("\"apple\" comes before \"banana\"");
        else
            Console.WriteLine("\"banana\" comes before \"apple\"");
    }
}
