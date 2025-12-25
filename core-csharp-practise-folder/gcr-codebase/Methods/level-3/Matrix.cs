using System;
class MatrixOperations{
    public static double[,] CreateMatrix(int rows, int cols){
        Random rand = new Random();
        double[,] matrix = new double[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                matrix[i, j] = rand.Next(1, 10);
        return matrix;
    }
    public static void DisplayMatrix(double[,] matrix){
        int r = matrix.GetLength(0);
        int c = matrix.GetLength(1);
        for (int i = 0; i < r; i++){
            for (int j = 0; j < c; j++)
                Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public static double[,] Add(double[,] A, double[,] B){
        int r = A.GetLength(0);
        int c = A.GetLength(1);
        double[,] result = new double[r, c];
        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                result[i, j] = A[i, j] + B[i, j];
        return result;
    }
    public static double[,] Subtract(double[,] A, double[,] B){
        int r = A.GetLength(0);
        int c = A.GetLength(1);
        double[,] result = new double[r, c];
        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                result[i, j] = A[i, j] - B[i, j];
        return result;
    }
    public static double[,] Multiply(double[,] A, double[,] B){
        int r1 = A.GetLength(0);
        int c1 = A.GetLength(1);
        int c2 = B.GetLength(1);
        double[,] result = new double[r1, c2];
        for (int i = 0; i < r1; i++)
            for (int j = 0; j < c2; j++)
                for (int k = 0; k < c1; k++)
                    result[i, j] += A[i, k] * B[k, j];

        return result;
    }
    public static double[,] Transpose(double[,] matrix){
        int r = matrix.GetLength(0);
        int c = matrix.GetLength(1);
        double[,] t = new double[c, r];
        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                t[j, i] = matrix[i, j];
        return t;
    }
    public static double Determinant2x2(double[,] m){
        return (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
    }
    public static double[,] Inverse2x2(double[,] ){
        double det = Determinant2x2(m);
        if (det == 0)
            throw new Exception("Inverse not possible");
        double[,] inv = new double[2, 2];
        inv[0, 0] = m[1, 1] / det;
        inv[0, 1] = -m[0, 1] / det;
        inv[1, 0] = -m[1, 0] / det;
        inv[1, 1] = m[0, 0] / det;

        return inv;
    }
    public static double Determinant3x3(double[,] m){
        return m[0,0]*(m[1,1]*m[2,2]-m[1,2]*m[2,1])
             - m[0,1]*(m[1,0]*m[2,2]-m[1,2]*m[2,0])
             + m[0,2]*(m[1,0]*m[2,1]-m[1,1]*m[2,0]);
    }
    static void Main(){
        double[,] A = CreateMatrix(2, 2);
        double[,] B = CreateMatrix(2, 2);
        Console.WriteLine("Matrix A:");
        DisplayMatrix(A);
        Console.WriteLine("Matrix B:");
        DisplayMatrix(B);
        Console.WriteLine("Addition:");
        DisplayMatrix(Add(A, B));
        Console.WriteLine("Subtraction:");
        DisplayMatrix(Subtract(A, B));
        Console.WriteLine("Multiplication:");
        DisplayMatrix(Multiply(A, B));
        Console.WriteLine("Transpose of A:");
        DisplayMatrix(Transpose(A));
        Console.WriteLine("Determinant of A:");
        Console.WriteLine(Determinant2x2(A));
        Console.WriteLine("Inverse of A:");
        DisplayMatrix(Inverse2x2(A));
    }
}
