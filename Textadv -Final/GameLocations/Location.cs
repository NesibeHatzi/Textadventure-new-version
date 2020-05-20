using System.Collections.Generic;
using Program.GameCharacters;
using Program.GameItems;

namespace Program.GameLocations
{
    public abstract class Location
    {
        protected string BaseDescription;
        protected string MonsterDescription;
        protected string FriendlyDescription;
        public Monster LocationMonster { get; protected set; }
        public Friendly LocationFriendly { get; protected set; }
        public bool IsMonsterAlive
        {
            get
            {
                return LocationMonster != null;
            }
        }

        public string Name { get; }
        public string Description { get; protected set; }
        public List<Item> Items { get; }
        public List<Character> Characters { get; }

        public void KillLocationMonster ()
        {
            LocationMonster = null;
            Description = BaseDescription;
        }

        protected Location (string name, string baseDescription)
        {
            Name = name;
            BaseDescription = baseDescription;
            Description = baseDescription;
            Items = new List<Item> ();
            Characters = new List<Character> ();
        }

        public void UpdateLocation ()
        {
            // Description
            Description = BaseDescription;
            if (IsMonsterAlive)
                Description += MonsterDescription.Replace ("MONSTER_NAME", LocationMonster.Name);
            if (LocationFriendly != null)
                Description += FriendlyDescription.Replace ("FRIENDLY_NAME", LocationFriendly.Name);
        }
    }
}