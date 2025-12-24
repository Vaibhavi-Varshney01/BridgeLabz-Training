using System;
class Student{
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        double[] percent = new double[n];
        char[] grade = new char[n];
        for (int i = 0; i < n; i++) {
            double p = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            percent[i] = (p + c + m) / 3;
            if (percent[i] >= 90) grade[i] = 'A';
            else if (percent[i] >= 75) grade[i] = 'B';
            else if (percent[i] >= 60) grade[i] = 'C';
            else grade[i] = 'D';
        }
        for (int i = 0; i < n; i++)
            Console.WriteLine(percent[i] + " " + grade[i]);
    }
}
