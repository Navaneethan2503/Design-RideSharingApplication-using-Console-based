using System;

namespace RideSharingApp.DTO{
    class Location{
        public int _lat ;
        public int _long;

        public Location(int x, int y){
            _lat = x;
            _long = y;
        }
    }
}