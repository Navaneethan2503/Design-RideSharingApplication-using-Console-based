using RideSharingApp.FareTypes;
using RideSharingApp.Notify;
using System;

namespace RideSharingApp{
    class Passenger : User, INotifiable{

        public IFareType fareType ;

        public Passenger(string name, Location location, IFareType fareType) : base(name, location)
        {
            this.fareType = fareType;
        }

        public void GetNotification(string status)
        {
            Console.WriteLine(name+": "+status);
        }

        public override string ToString(){
            return $"Passenger Name is : {name}.";
        }
    }
}