using System;
class Calendar{
    static bool IsLeap(int y)
        => (y % 4 == 0 && y % 100 != 0) || y % 400 == 0;
    static int GetFirstDay(int m, int y){
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        return (1 + x + (31 * m0) / 12) % 7;
    }
    static void Main(){
        Console.Write("Month: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Year: ");
        int y = int.Parse(Console.ReadLine());
        int[] days = { 31, IsLeap(y) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        int start = GetFirstDay(m, y);        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
        for (int i = 0; i < start; i++) Console.Write("    ");
        for (int d = 1; d <= days[m - 1]; d++){
            Console.Write($"{d,3} ");
            if ((d + start) % 7 == 0) Console.WriteLine();
        }
    }
}
