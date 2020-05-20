using Program.GameCharacters;
using Program.GameItems;

namespace Program.GameLocations
{
    class Castle : Location
    {
        public Castle () : base ("The Castle", "A huge castle, but it is so quiet here.|\r\n")
        {
            // Items
            Items.Add (new VikingShield ());

            // Friendly
            LocationFriendly = Friendly.CreateFriendly (Friendlies.Fairy);
            Characters.Add (LocationFriendly);
            FriendlyDescription = "Someone comes: it's the FRIENDLY_NAME. Do you want to talk (o)";

            // Monster
            MonsterDescription = "";

            UpdateLocation ();
        }
    }
}