using System;
public class Magazine : LibraryItem, IReservable{
    private bool isAvailable = true;
    public override int GetLoanDuration(){
        return 7;
    }
    public void ReserveItem(){
        isAvailable = false;
        Console.WriteLine("Magazine Reserved");
    }
    public bool CheckAvailability(){
        return isAvailable;
    }
}
