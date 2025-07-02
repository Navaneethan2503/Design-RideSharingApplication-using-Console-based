using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApp
{
    public interface IVehicle
    {
        string VehicleType { get; set; }

        int BaseFare { get; set; }

    }
}
