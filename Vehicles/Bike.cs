using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApp
{
    public class Bike : IVehicle
    {

        public string VehicleType { get; set; }
        public int BaseFare { get; set; }

        public Bike()
        {
            VehicleType = "bike";
            BaseFare = 15;
        }
    }
}
