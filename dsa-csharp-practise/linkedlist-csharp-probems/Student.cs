using System;
class StudentNode{
    public int Roll;
    public string Name;
    public int Age;
    public char Grade;
    public StudentNode Next;

    public StudentNode(int roll, string name, int age, char grade){
        Roll = roll;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}
class Student{
    StudentNode head;
    public void AddAtEnd(int r, string n, int a, char g){
        StudentNode newNode = new StudentNode(r, n, a, g);
        if (head == null){
            head = newNode;
            return;
        }
        StudentNode temp = head;
        while (temp.Next != null)
            temp = temp.Next;
        temp.Next = newNode;
    }
    public void Delete(int roll){
        if (head == null) return;
        if (head.Roll == roll)
        {
            head = head.Next;
            return;
        }
        StudentNode temp = head;
        while (temp.Next != null && temp.Next.Roll != roll)
            temp = temp.Next;

        if (temp.Next != null)
            temp.Next = temp.Next.Next;
    }

    public void Search(int roll)
    {
        StudentNode temp = head;
        while (temp != null)
        {
            if (temp.Roll == roll)
            {
                Console.WriteLine($"Found: {temp.Name}, Grade: {temp.Grade}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found");
    }

    public void UpdateGrade(int roll, char newGrade)
    {
        StudentNode temp = head;
        while (temp != null)
        {
            if (temp.Roll == roll)
            {
                temp.Grade = newGrade;
                return;
            }
            temp = temp.Next;
        }
    }

    public void Display()
    {
        StudentNode temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.Roll} {temp.Name} {temp.Age} {temp.Grade}");
            temp = temp.Next;
        }
    }
}
