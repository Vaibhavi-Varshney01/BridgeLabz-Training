using System;
public class DVD : LibraryItem, IReservable{
    private bool isAvailable = true;
    public override int GetLoanDuration(){
        return 3;
    }
    public void ReserveItem(){
        isAvailable = false;
        Console.WriteLine("DVD Reserved");
    }
    public bool CheckAvailability(){
        return isAvailable;
    }
}
