namespace RideSharingApp
{
    internal abstract class User
    {

        public string name;

        public Location location;

        public User(string name, Location location)
        {
            this.name = name;   
            this.location = location;
        }

    }
}
