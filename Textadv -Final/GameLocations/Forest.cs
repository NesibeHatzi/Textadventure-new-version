using Program.GameCharacters;
using Program.GameItems;

namespace Program.GameLocations
{
    internal class Forest : Location
    {
        public Forest () : base ("The Forest", "A forest full of lush trees.")
        {
            // Items
            Items.Add (new ShortSword ());

            // Friendly
            FriendlyDescription = "";

            // Monster
            LocationMonster = Monster.CreateMonster (Monsters.Bear);
            Characters.Add (LocationMonster);
            MonsterDescription = "Also there is an evil creature named MONSTER_NAME. Want to fight? Yes (f); No (x)";

            UpdateLocation ();
        }
    }
}