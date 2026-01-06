public class InPatient : Patient, IPayable{
  public int numberOfDays{get; set; }
  public double DailyCharge {get; set; }

  public InPatient(string name, int PatientID, int Age, int days, double charge : base(PatientID, Name, Age )){
    numberOfDays = days;
    DailyCharge = charge;
  }
  
  public double CalculateBill(){
    return numberOfDays * DailyCharge;
  }
  public override void DisplayInfo(){
    base.DisplayInfo();
    Console.WriteLine($"Patient Type: In-Patient");
    Console.WriteLine($"Total Bill: Rs. {CalculateBill}");
  }
} 