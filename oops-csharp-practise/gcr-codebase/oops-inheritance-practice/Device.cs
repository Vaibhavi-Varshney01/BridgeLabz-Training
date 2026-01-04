using System;
class Device{
    public string DeviceId;
    public string Status;
}
class Thermostat : Device{
    public int TemperatureSetting;
    public void DisplayStatus(){
        Console.WriteLine($"{DeviceId}, {Status}, Temp: {TemperatureSetting}");
    }
}
