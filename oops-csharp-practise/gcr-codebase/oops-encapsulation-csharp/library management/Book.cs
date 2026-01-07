using System;
public class Book : LibraryItem, IReservable{
    private bool isAvailable = true;
    public override int GetLoanDuration(){
        return 15;
    }
    public void ReserveItem(){
        isAvailable = false;
        Console.WriteLine("Book Reserved");
    }
    public bool CheckAvailability(){
        return isAvailable;
    }
}
