namespace Program.GameItems
{
    class ShortSword : Item, IWeapon
    {
        public ShortSword() : base("Short Sword")
        {
            Damage = 8;
            HandsRequired = 1;
        }

        public int Damage { get; }

        public int HandsRequired { get; }
    }
}