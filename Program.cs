using RideSharingApp.AbstractClassDemo;
using RideSharingApp.DTO;
using RideSharingApp.FareTypes;
using RideSharingApp.Models;
using System;

namespace RideSharingApp{
    class Program{
        public static void Main(){
            Console.WriteLine("Welcome to Ride Sharing App.");
            RideBookingService app = new RideBookingService();
            app.addDriver("nickil", new Car(), new Location(10, 8));
            app.addDriver("nava", new Bike(), new Location(7, 4));
            app.DisplayDrivers();

            Passenger p1 = new Passenger("neha", new Location(7, 4), new StandardFareType());
            Passenger p2 = new Passenger("vijaya Kumar", new Location(17, 2), new LuxaryFareType());
            app.RequestRide(p1, 10);
            app.RequestRide(p2, 20);

            Passenger p3 = new Passenger("vijay", new Location(1, 2), new SharedFareType());
            app.RequestRide(p3,30);


            //Abstract Class Demonstration
            MathsBooks book = new MathsBooks(1,"Maths", "somethisn", "nava");
            Book book2 = new MathsBooks(2, "Maths 2", "somethisn 2", "nava 2");

            Book b1 = book.GetBook();
            Book b2 = book.GetBookByBook();

        }
    }
}