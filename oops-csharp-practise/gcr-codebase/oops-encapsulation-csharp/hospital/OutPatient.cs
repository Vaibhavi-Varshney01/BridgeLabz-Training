using System;
public class OutPatient : Patient, IMedicalRecord{
    private string medicalRecord;
    public override double CalculateBill(){
        billAmount = 800;
        return billAmount;
    }
    public void AddRecord(string record){
        medicalRecord = record;
    }
    public void ViewRecords(){
        Console.WriteLine("Medical Record: " + medicalRecord);
    }
}
