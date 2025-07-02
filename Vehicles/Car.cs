using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApp
{
    public class Car : IVehicle
    {
        public string VehicleType { get; set; }
        public int BaseFare { get; set; }

        public Car() {
            VehicleType = "car";
            BaseFare = 25;
        }




    }
}
