using System;
class University{
    public int rollNumber;
    protected string name;
    private double CGPA;
    public void SetCGPA(double cgpa){
        CGPA = cgpa;
    }
    public double GetCGPA(){
        return CGPA;
    }
}
class PostgraduateStudent : Student{
    public void ShowName(){
        name = "Vaibhavi";
        Console.WriteLine("Student Name: " + name);
    }
}
