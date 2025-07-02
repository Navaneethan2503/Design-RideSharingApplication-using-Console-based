using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApp.FareTypes
{
    internal class StandardFareType : IFareType
    {
        public string type { get; set; }
        public double FareRate { get; set; }

        public StandardFareType()
        {
            type = "standard";
            FareRate = 1.0;
        }
    }
}
