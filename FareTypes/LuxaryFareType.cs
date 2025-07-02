using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApp.FareTypes
{
    internal class LuxaryFareType : IFareType
    {
        public string type { get; set; }
        public double FareRate { get; set; }

        public LuxaryFareType()
        {
            type = "Shared";
            FareRate = 2.0;
        }
    }
}
