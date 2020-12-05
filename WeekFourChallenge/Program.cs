using System;

namespace WeekFourChallenge
{
    public abstract class Vehicle
    {
        public double Distance { get; set; }
        public double Mpg { get; set; }
        public double Fuel { get; set; }
        public double Hour { get; set; }

        public abstract void RangeSpeed(double mpg, double fuel, double distance, double hour);
        public Vehicle() { }
        public Vehicle(double mpg, double fuel, double distance, double hour)
        {
            Distance = distance;
            Mpg = mpg;
            Fuel = fuel;
            Hour = hour;
        }
    }
    public class Car : Vehicle
    {
        public Car() { }

        public Car(double mpg, double fuel, double distance, double hour)
            : base(mpg, fuel, distance, hour)
        { }

        public override void RangeSpeed(double mpg, double fuel, double distance, double hour)
        {
            double fuelRange = fuel * mpg;
            Console.WriteLine($"\nCar's Fuel Range is {fuelRange} Miles.");
            double milesPerHour = distance / hour;
            Console.WriteLine($"Car's Speed will be {milesPerHour} MPH.\n");
        }
    }   
    public class Truck : Vehicle
    {
        public Truck() { }

        public Truck(double mpg, double fuel, double distance, double hour)
            : base(mpg, fuel, distance, hour)
        { }

        public override void RangeSpeed(double mpg, double fuel, double distance, double hour)
        {
            double fuelRange = fuel * mpg;
            Console.WriteLine($"\nCar's Fuel Range is {fuelRange} Miles.");
            double milesPerHour = distance / hour;
            Console.WriteLine($"Car's Speed will be {milesPerHour} MPH.\n");
        }
    }
   class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.RangeSpeed(25.5, 20.5, 200.0, 4.0);
            
            Truck truck = new Truck();
            truck.RangeSpeed(15.7, 62.5, 500.0, 8.5);
        }
    }
}
