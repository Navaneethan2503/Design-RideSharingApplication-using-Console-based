using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApp.FareTypes
{
    internal class SharedFareType : IFareType
    {
        public string type { get; set; }
        public double FareRate { get; set; }

        public SharedFareType() {
            type = "Shared";
            FareRate = 0.5;
        }

    }
}
