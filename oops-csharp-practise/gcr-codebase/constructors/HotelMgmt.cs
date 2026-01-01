using System;
class Hotel{
  public string guestName;
  public string roomType;
  public int nights;

  public Hotel(string guestName, string roomType, int nights){
    this.guestName = guestName;
    this.roomType = roomType;
    this.nights = nights;
  }
  public Hotel(){
    guestName = "Guest";
    roomType = "Standard";
    nights = 1;
  }
  public Hotel(Hotel h1){
    this.guestName = h1.guestName;
    this.roomType = h1.roomType;
    this.nights = h1.nights;
  }

  public void Display(){
    Console.WriteLine("Guest Name: " + guestName);
    Console.WriteLine("Room Type: " + roomType);
    Console.WriteLine("Number of Nights: " + nights);
    Console.WriteLine("---------------------------");
  }
}
class HotelMgmt{
  static void Main(){
    Hotel h1 = new Hotel();
    h1.Display();

    Hotel h2 = new Hotel("Vaibhavi" , "Deluxe" , "2");
    h2.Display();

    Hotel h3 = new Hotel(h2);
    h3.Display();
  }
}