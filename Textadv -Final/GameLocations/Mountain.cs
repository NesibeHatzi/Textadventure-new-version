using Program.GameCharacters;
using Program.GameItems;

namespace Program.GameLocations
{
    internal class Mountain : Location
    {
        public Mountain () : base ("Mountain", "A very dangerous mountain and it is so incredibly quiet here !?|\r\n")
        {
            // Items
            Items.Add (new Gun ());

            // Friendly
            LocationFriendly = Friendly.CreateFriendly (Friendlies.Fairy);
            Characters.Add (LocationFriendly);
            FriendlyDescription = "Someone comes: it's the FRIENDLY_NAME. Do you want to talk (o)";

            // Monster
            LocationMonster = Monster.CreateMonster (Monsters.Dragon);
            Characters.Add (LocationMonster);
            MonsterDescription = "OOoo there comes the dangerous MONSTER_NAME. Want to fight? Yes (f); No (x)";

            UpdateLocation ();
        }
    }
}