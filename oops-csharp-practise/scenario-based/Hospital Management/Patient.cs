public class Patient{
  public int PatientID {get; set; }
  public string Name {get; set; }
  public int Age {get; set;}

  public Patient(string PatientID, string Name, int Age){
    this.PatientID = PatientID;
    this.Name = Name;
    this.Age = Age;
  }

  public virtual void DisplayInfo(){
    Console.WriteLine($"Patient ID: {PatientID}");
    Console.WriteLine($"Name: {Name}");
    Console.WriteLine($"Age: " + {Age});
  }
}