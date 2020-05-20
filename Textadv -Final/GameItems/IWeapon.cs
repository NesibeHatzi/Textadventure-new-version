namespace Program.GameItems
{
    interface IWeapon
    {
        int Damage { get; }
        
        int HandsRequired { get; }
    }
}