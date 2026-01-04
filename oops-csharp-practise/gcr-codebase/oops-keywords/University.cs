using System;
class Student{
    // static variable
    public static string UniversityName = "ABC University";
    private static int totalStudents = 0;
    public readonly int RollNumber;
    public string Name;
    public string Grade;
    // constructor 
    public Student(string name, int rollNumber, string grade){
        this.Name = name;
        this.RollNumber = rollNumber;
        this.Grade = grade;
        totalStudents++;
    }
    // static method
    public static void DisplayTotalStudents(){
        Console.WriteLine("Total Students Enrolled: " + totalStudents);
    }
    public void Display(){
        Console.WriteLine($"Name: {Name}, Roll No: {RollNumber}, Grade: {Grade}");
    }
}
class University{
    static void Main(){
        Student s1 = new Student("Rahul", 101, "A");
        Student s2 = new Student("Anita", 102, "B");
        object obj = s1;
        // is operator
        if (obj is Student){
            Student stu = (Student)obj;
            stu.Display();
        }
        Student.DisplayTotalStudents();
    }
}
