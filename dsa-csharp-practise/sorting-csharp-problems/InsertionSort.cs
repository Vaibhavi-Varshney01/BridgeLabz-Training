using System;
class InsertionSort{
    static void Main(){
        int [] empID = {105, 102, 110, 101, 108};
        for(int i = 0; i<empID.Length; i++){
            int key = empID[i];
            int j = i-1;
            while(j >= 0 && empID[j] > key){
                empID[j+1] = empID[j];
                j--;
            }
            empID[j+1] = empID[j];
        }
        Console.WriteLine("Employee IDs after sorting: ");
        for(int i = 0; i,empID.Length; i++){
            Console.WriteLine(empID[i]);
        }
    }
}