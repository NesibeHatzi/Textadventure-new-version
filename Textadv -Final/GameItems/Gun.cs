namespace Program.GameItems
{
    class Gun : Item, IWeapon
    {
        public Gun() : base("The Gun")
        {
            HandsRequired = 1;
            Damage = 80;
        }

        public int HandsRequired { get; }

        public int Damage { get; }
    }
}