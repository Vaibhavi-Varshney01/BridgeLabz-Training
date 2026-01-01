using System;
class CarRental{
    public string customerName;
    public string carModel;
    public int rentalDays;
    public int costPerDay = 1000;
    public CarRental(string customerName, string carModel, int rentalDays){
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
    }
    public void CalculateTotalCost(){
        int totalCost = rentalDays * costPerDay;
        Console.WriteLine($"Total Rental Cost: {totalCost}");
    }
}
