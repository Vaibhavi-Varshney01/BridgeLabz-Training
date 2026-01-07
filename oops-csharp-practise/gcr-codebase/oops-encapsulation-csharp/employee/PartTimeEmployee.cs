public class PartTimeEmployee : Employee, IDepartment
{
    private int hoursWorked;
    private double ratePerHour = 500;

    public PartTimeEmployee(int hours)
    {
        hoursWorked = hours;
    }

    public override double CalculateSalary()
    {
        return hoursWorked * ratePerHour;
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
