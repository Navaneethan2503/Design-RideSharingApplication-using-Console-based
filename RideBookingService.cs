using RideSharingApp.DTO;
using RideSharingApp.Models;
using RideSharingApp.Notify;
using System;

namespace RideSharingApp{
    class RideBookingService : IObserver{
        List<Driver> drivers ;

        public RideBookingService(){
            drivers = new List<Driver>();
        }

        public void addDriver(string name, IVehicle vehicle, Location location){
            drivers.Add(new Driver(name, vehicle, location));
        }

        public void RequestRide(Passenger passenger, double distance)
        {
            if(drivers.Count <=0)
            {
                Console.WriteLine("No Drivers Available.");
            }
            //Find Nearest Direvers
            Driver assignedDriver = FindNearestDriver(passenger.location, distance);
            if (assignedDriver != null) {
                assignedDriver.BookRide();
                Ride ride = new Ride(passenger, assignedDriver, distance);
                double rideFare = ride.CalculateFare();
                Console.WriteLine($"Ride Booked, for Passenger : {passenger.name} and Driver Name is : {assignedDriver.name} and Vehichle is : {assignedDriver.vehicle.VehicleType} and Fare is :{rideFare}.");
                ride.UpdateStatus(Status.RideStatus.Ongoing);   
                Notify("Ride Stated", passenger, assignedDriver);
            }
            else
            {
                Console.WriteLine("Drivers not available at the moment, please Try Again Later.");
            }

        }

        public Driver FindNearestDriver(Location location,double distance)
        {
            Driver driver = null;
            double minDistance = double.MaxValue;
            foreach(Driver d in drivers)
            {
                if (d.status == DriverStatusEnum.Available) {
                    double la = d.location._lat - location._lat;
                    double lon = d.location._lat - location._long;
                    double dis = Math.Sqrt(la * la + lon * lon);
                    if (dis < minDistance)
                    {
                        minDistance = dis;
                        driver = d;
                    }
                }
            }
            return driver;
        }

        public void DisplayDrivers(){
            if(drivers.Count <= 0){
                Console.WriteLine("No Drivers Exists");
            }
            foreach(Driver d in drivers){
                Console.WriteLine("Driver Name :"+d.name);
            }
        }

        public void Notify(string status, Passenger passenger, Driver driver)
        {
            passenger.GetNotification(status);
            driver.GetNotification(status);
        }
    }
}