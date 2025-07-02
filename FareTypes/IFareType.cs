namespace RideSharingApp.FareTypes
{
    interface IFareType
    {
        public string type { get; set; }

        public double FareRate { get; set; }

    }
}
