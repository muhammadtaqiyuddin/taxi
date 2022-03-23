// See https://aka.ms/new-console-template for more information
using LatihanTaxi;

class program
{
    static void Main(string[] args)
    {
        // membuat objek Taxi
        Taxi taxi = new Taxi();

        // pengesetan nilai properties
        taxi.DriverName = "Jono";
        taxi.OnDuty = true;
        taxi.NumPassenger = 10;

        // Pemanggilan method
        taxi.TaxiInfo();
        taxi.PickUpPassenger();
        taxi.DropOffPassenger();

        Console.ReadKey();
    }
}
