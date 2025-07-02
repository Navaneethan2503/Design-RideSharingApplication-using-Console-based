using RideSharingApp.FareTypes;
using RideSharingApp.Models;
using RideSharingApp.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApp
{
    internal class Ride
    {
        public Passenger passenger;

        public Driver driver;

        public double distance;

        public RideStatus status;

        public double RideRate;
        
        public Ride(Passenger p, Driver d, double dis)
        {
            passenger = p;
            driver = d;
            distance = dis;
            status = RideStatus.Sheduled;
        }

        public double CalculateFare()
        {
            double baseFare = ((double)driver.vehicle.BaseFare * distance / 10);
            RideRate = passenger.fareType.FareRate * baseFare;
            return RideRate;
        }

        public void UpdateStatus(RideStatus s) {
            status = s;
        }
    }
}
