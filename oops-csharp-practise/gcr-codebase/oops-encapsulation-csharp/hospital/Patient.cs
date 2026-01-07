using System;
public abstract class Patient{
    private int patientId;
    private string name;
    private int age;
    protected double billAmount;
    public int PatientId{
        get { return patientId; }
        set { patientId = value; }
    }
    public string Name{
        get { return name; }
        set { name = value; }
    }
    public int Age{
        get { return age; }
        set { age = value; }
    }
    public abstract double CalculateBill();
    public void GetPatientDetails(){
        Console.WriteLine("Patient ID : " + PatientId);
        Console.WriteLine("Name       : " + Name);
        Console.WriteLine("Age        : " + Age);
        Console.WriteLine("Bill       : " + CalculateBill());
        Console.WriteLine("-------------END---------------");
    }
}
