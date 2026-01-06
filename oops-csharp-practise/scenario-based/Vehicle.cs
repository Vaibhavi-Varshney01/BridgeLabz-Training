using System;
// Interface for renting
interface IRentable{
    double CalculateRent(int days);
}
// Base Vehicle Class
class Vehicle{
    protected string VehicleNumber;
    public string Model { get; set; }
    public Vehicle(string number, string model)
    {
        VehicleNumber = number;
        Model = model;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Vehicle: " + Model + " | Number: " + VehicleNumber);
    }
}
// Car class
class Car : Vehicle, IRentable{
    public Car(string number, string model) : base(number, model) { }
    public double CalculateRent(int days){
        return days * 1500;  // Rent per day
    }
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Type: Car");
    }
}
// Bike class
class Bike : Vehicle, IRentable{
    public Bike(string number, string model) : base(number, model) { }

    public double CalculateRent(int days)
    {
        return days * 500;  // Rent per day
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Type: Bike");
    }
}

// Truck class
class Truck : Vehicle, IRentable
{
    public Truck(string number, string model) : base(number, model) { }

    public double CalculateRent(int days)
    {
        return days * 3000;  // Rent per day
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Type: Truck");
    }
}

// Customer class
class Customer
{
    public string Name { get; set; }
    public Vehicle RentedVehicle { get; set; }

    public Customer(string name, Vehicle vehicle)
    {
        Name = name;
        RentedVehicle = vehicle;
    }

    public void ShowRentalInfo(int days)
    {
        Console.WriteLine("\nCustomer: " + Name);
        RentedVehicle.DisplayInfo();
        double rent = (RentedVehicle as IRentable).CalculateRent(days);
        Console.WriteLine("Total Rent for " + days + " days: " + rent);
    }
}

// Main Program
class Program
{
    static void Main()
    {
        // Create vehicles
        Vehicle car = new Car("CAR123", "Honda City");
        Vehicle bike = new Bike("BIKE456", "KTM Duke");
        Vehicle truck = new Truck("TRK789", "Tata Truck");

        // Create customers
        Customer c1 = new Customer("Vaibhavi", car);
        Customer c2 = new Customer("Rahul", bike);
        Customer c3 = new Customer("Sneha", truck);

        // Show rental info
        c1.ShowRentalInfo(3);   // 3 days
        c2.ShowRentalInfo(2);   // 2 days
        c3.ShowRentalInfo(5);   // 5 days
    }
}
