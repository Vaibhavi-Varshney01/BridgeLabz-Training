using System;
abstract class LoanApplication : IApprovable
{
    protected Applicant applicant;
    protected int term; // months
    protected double interestRate;

    private bool loanApproved;

    public LoanApplication(Applicant applicant, int term, double interestRate)
    {
        this.applicant = applicant;
        this.term = term;
        this.interestRate = interestRate;
    }

    protected bool BasicEligibilityCheck()
    {
        return applicant.GetCreditScore() >= 650 &&
               applicant.GetIncome() >= applicant.GetLoanAmount() / 10;
    }

    protected void SetLoanStatus(bool status)
    {
        loanApproved = status;
    }

    public bool GetLoanStatus()
    {
        return loanApproved;
    }

    public abstract bool ApproveLoan();
    public abstract double CalculateEMI();
}
