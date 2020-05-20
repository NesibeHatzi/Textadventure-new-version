using Program.GameCharacters;
using Program.GameItems;

namespace Program.GameLocations
{
    class Cave : Location
    {
        public Cave () : base ("The Cave", "The cave is dark and damp, it stinks here too!")
        {
            // Items
            Items.Add (new LongSword ());

            // Friendly
            FriendlyDescription = "";

            // Monster
            MonsterDescription = "";

            UpdateLocation ();
        }
    }
}