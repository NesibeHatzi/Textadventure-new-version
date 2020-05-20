namespace Program.GameItems
{
    class DarkCrystal : Item, IArmor
    {
        public DarkCrystal() : base("Dark Crystal")
        {
           
            Weight = 5;
            Protection = 80;
        }

        public int Weight { get; }

        public int Protection { get; }
    }
}
