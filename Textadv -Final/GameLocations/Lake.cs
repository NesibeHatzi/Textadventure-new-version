using Program.GameItems;

namespace Program.GameLocations
{
    class Lake : Location
    {
        public Lake () : base ("The Lake", "A beautiful lake surrounded by trees.")
        {
            // Items
            Items.Add (new DarkCrystal ());

            // Friendly
            FriendlyDescription = "";

            // Monster
            MonsterDescription = "";

            UpdateLocation ();
        }
    }
}