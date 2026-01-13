using System;
class MatrixSearch{
    static void Main(){
        int[,] matrix ={
            {1, 3, 5},
            {7, 9, 11},
            {13, 15, 17}
        };
        int target = 9;
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int low = 0, high = rows * cols - 1;
        while (low <= high){
            int mid = (low + high) / 2;
            int value = matrix[mid / cols, mid % cols];

            if (value == target)
            {
                Console.WriteLine("Target Found");
                return;
            }
            else if (value < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        Console.WriteLine("Target Not Found");
    }
}
