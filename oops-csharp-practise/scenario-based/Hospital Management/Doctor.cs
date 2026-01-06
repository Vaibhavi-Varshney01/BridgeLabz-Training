public class Doctor
{
    public int DoctorId { get; set; }
    public string DoctorName { get; set; }
    public string Specialization { get; set; }

    public void DisplayDoctorInfo()
    {
        Console.WriteLine($"Doctor ID: {DoctorId}");
        Console.WriteLine($"Doctor Name: {DoctorName}");
        Console.WriteLine($"Specialization: {Specialization}");
    }
}
