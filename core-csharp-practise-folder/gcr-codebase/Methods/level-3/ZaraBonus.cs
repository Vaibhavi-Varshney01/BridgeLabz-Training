using System;
class ZaraBonus{
    static void Main(){
        Random r = new Random();
        double[,] emp = new double[10, 2];
        for (int i = 0; i < 10; i++){
            emp[i, 0] = r.Next(10000, 99999);
            emp[i, 1] = r.Next(1, 11);
        }
        double totalBonus = 0;
        for (int i = 0; i < 10; i++){
            double bonus = emp[i,1] > 5 ? emp[i,0]*0.05 : emp[i,0]*0.02;
            totalBonus += bonus;
        }
        Console.WriteLine("Total Bonus: " + totalBonus);
    }
}
