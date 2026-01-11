using System;
class BubbleSort{
    static void Main(){
        int [] marks = {45, 89, 23, 67, 12};
        for(int i = 0; i<marks.Length; i++){
            Console.WriteLine(marks[i]);
        }
        for(int i = 0; i<marks.Length; i++){
            for(int j = 0; j<marks.Length; j++){
                if(marks[j] > marks[j+1]){
                    int temp = marks[j];
                    marks[j] = marks[j+1];
                    marks[j+1] = temp;
                }
            }
        }
        Console.WriteLine("Marks after sorting: ");
        for(int i = 0; i<marks.Length; i++){
            Console.WrteLine(marks[i]);
        }
    }
}