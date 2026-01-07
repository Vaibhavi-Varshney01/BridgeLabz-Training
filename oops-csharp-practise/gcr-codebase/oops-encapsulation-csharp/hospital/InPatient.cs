using System;
public class InPatient : Patient, IMedicalRecord{
    private int daysAdmitted;
    private string medicalRecord;
    public InPatient(int days){
        daysAdmitted = days;
    }
    public override double CalculateBill(){
        billAmount = daysAdmitted * 3000;
        return billAmount;
    }
    public void AddRecord(string record){
        medicalRecord = record;
    }
    public void ViewRecords(){
        Console.WriteLine("Medical Record: " + medicalRecord);
    }
}
