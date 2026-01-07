public class FullTimeEmployee : Employee, IDepartment
{
    public FullTimeEmployee(double salary)
    {
        baseSalary = salary;
    }

    public override double CalculateSalary()
    {
        return baseSalary;
    }

    public void AssignDepartment(string dept)
    {
        department = dept;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }
}
