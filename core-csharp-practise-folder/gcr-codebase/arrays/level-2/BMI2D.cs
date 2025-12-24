using System;
class BMI2D {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        double[][] personData = new double[n][];
        string[] status = new string[n];
        for (int i = 0; i < n; i++) {
            personData[i] = new double[3];
            personData[i][0] = double.Parse(Console.ReadLine()); // weight
            personData[i][1] = double.Parse(Console.ReadLine()); // height
            personData[i][2] = personData[i][0] / (personData[i][1] * personData[i][1]);
            if (personData[i][2] < 18.5) status[i] = "Underweight";
            else if (personData[i][2] < 25) status[i] = "Normal";
            else status[i] = "Overweight";
        }
        for (int i = 0; i < n; i++)
            Console.WriteLine(personData[i][1] + " " + personData[i][0] + " " + personData[i][2] + " " + status[i]);
    }
}
