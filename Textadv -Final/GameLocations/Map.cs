namespace Program.GameLocations
{
    class Map
    {
        public Location Forest { get; }
        public Location Mountain { get; }
        public Location Lake { get; }
        public Location Castle { get; }
        public Location Cave { get; }

        public Map()
        {
            Forest = new Forest();
            Mountain = new Mountain();
            Lake = new Lake();
            Castle = new Castle();
            Cave = new Cave();
        }

        public Location NorthOf(Location reference)
        {
            if (reference == Mountain) return Forest;
            if (reference == Forest) return Cave;
            return null;
        }

        public Location SouthOf(Location reference)
        {
            if (reference == Cave) return Forest;
            if (reference == Forest) return Mountain;
            return null;
        }

        public Location EastOf(Location reference)
        {
            if (reference == Castle) return Forest;
            if (reference == Forest) return Lake;
            return null;
        }

        public Location WestOf(Location reference)
        {
            if (reference == Lake) return Forest;
            if (reference == Forest) return Castle;
            return null;
        }
    }
}