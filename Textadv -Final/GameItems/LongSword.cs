namespace Program.GameItems
{
    class LongSword : Item, IWeapon
    {
        public LongSword() : base("Long Sword")
        {
            Damage = 16;
            HandsRequired = 2;
        }

        public int Damage { get; }

        public int HandsRequired { get; }
    }
}