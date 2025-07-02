using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApp.Notify
{
    internal interface IObserver
    {
        void Notify(string status,Passenger passenger, Driver driver);
    }
}
