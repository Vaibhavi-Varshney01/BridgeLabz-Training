using System;
class Course{
    public string courseName;
    public int duration;
    public double fee;
    public static string instituteName = "ABC Institute";
    public Course(string courseName, int duration, double fee){
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }
    public void DisplayCourseDetails(){
        Console.WriteLine($"{courseName}, {duration} months, Fee: {fee}, Institute: {instituteName}");
    }
    public static void UpdateInstituteName(string newName){
        instituteName = newName;
    }
}
