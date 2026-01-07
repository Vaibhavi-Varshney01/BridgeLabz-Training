using System;
class Program{
    static void Main(string[] args){
        // InPatient Object
        Patient p1 = new InPatient(5);
        p1.PatientId = 1;
        p1.Name = "Ramesh";
        p1.Age = 45;
        IMedicalRecord record1 = (IMedicalRecord)p1;
        record1.AddRecord("Diabetes - ICU Admission");
        // OutPatient Object
        Patient p2 = new OutPatient();
        p2.PatientId = 2;
        p2.Name = "Sita";
        p2.Age = 30;
        IMedicalRecord record2 = (IMedicalRecord)p2;
        record2.AddRecord("Fever - OPD Visit");
        p1.GetPatientDetails();
        record1.ViewRecords();
        p2.GetPatientDetails();
        record2.ViewRecords();
        Console.ReadLine();
    }
}
