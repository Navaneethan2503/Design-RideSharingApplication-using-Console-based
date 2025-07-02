using RideSharingApp.DTO;
using RideSharingApp.Notify;

namespace RideSharingApp.Models{
    class Driver : User, INotifiable{

        public IVehicle vehicle ;

        public DriverStatusEnum status;

        public Driver(string name, IVehicle vehicle, Location location) : base(name, location)
        {
            this.vehicle = vehicle;
            status = DriverStatusEnum.Available;
        }

        public void GetNotification(string status)
        {
            Console.WriteLine(name+": "+status);
        }

        public void BookRide()
        {
            status = DriverStatusEnum.InProgress;
        }

        public override string ToString(){
            return $"Driver Name is : {name}.";
        }
    }
}