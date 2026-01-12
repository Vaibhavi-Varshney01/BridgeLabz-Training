using System;
class Program{
    static void Main(){
        Applicant applicant = new Applicant("Aman", 720, 90000, 600000);
        LoanApplication loan = new HomeLoan(applicant, 240); // polymorphism
        if (loan.ApproveLoan()){
            Console.WriteLine("Loan Approved ");
            Console.WriteLine("Monthly EMI: " + loan.CalculateEMI());
        }
        else{
            Console.WriteLine("Loan Rejected ");
        }
    }
}
