using System;
namespace Sorting{
    class Program{
    static void Main(){
        int [] dailySteps = {4500, 8000, 6200, 9000, 7000};
        BubbleSorting.BubbleSort(dailySteps);
        BubbleSorting.DisplayLeaderBoard(dailySteps);
    }
   }  
}
