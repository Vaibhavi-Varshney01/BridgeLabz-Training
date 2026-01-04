using System;
class Patient{
    // static variable
    public static string HospitalName = "City Hospital";
    private static int totalPatients = 0;
    public readonly int PatientID;
    public string Name;
    public int Age;
    public string Ailment;
    // constructor
    public Patient(string name, int age, string ailment, int patientID){
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        this.PatientID = patientID;
        totalPatients++;
    }
    // static method
    public static void GetTotalPatients(){
        Console.WriteLine("Total Patients Admitted: " + totalPatients);
    }
    public void Display(){
        Console.WriteLine($"ID: {PatientID}, Name: {Name}, Age: {Age}, Ailment: {Ailment}");
    }
}
class Hospital{
    static void Main(){
        Patient p1 = new Patient("Sita", 30, "Fever", 201);
        object obj = p1;
        if (obj is Patient){
            Patient pat = (Patient)obj;
            pat.Display();
        }
        Patient.GetTotalPatients();
    }
}
