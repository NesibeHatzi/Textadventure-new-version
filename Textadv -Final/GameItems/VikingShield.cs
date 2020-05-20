namespace Program.GameItems
{
    class VikingShield : Item, IArmor
    {
        public VikingShield() : base("Wiking Shield")
        {
            Weight = 20;
            Protection = 20;
        }

        public int Weight { get; }

        public int Protection { get; }
    }
}