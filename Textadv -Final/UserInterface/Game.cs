using Program.GameLocations;

namespace Program.UserInterface
{
    internal class Game
    {
        public Avatar Avatar { get; }
        public Map    Map    { get; }
        public bool   IsOver { get; private set; }


        public Game()
        {
            Avatar          = new Avatar();
            Map             = new Map();
            Avatar.Location = Map.Forest;
        }


        public void Quit()
        {
            IsOver = true;
        }


        public void MoveAvatarToNewLocation(Location destination)
        {
            Avatar.Location = destination;
        }


        public void MoveItemFromLocationToAvatar(int itemIndex)
        {
            if (0 <= itemIndex && itemIndex < Avatar.Location.Items.Count)
            {
                var item = Avatar.Location.Items[itemIndex];
                Avatar.Location.Items.RemoveAt(itemIndex);
                Avatar.Inventory.Add(item);
            }
        }


        public void MoveItemFromAvatarToLocation(int itemIndex)
        {
            if (0 <= itemIndex && itemIndex < Avatar.Inventory.Count)
            {
                var item = Avatar.Inventory[itemIndex];
                Avatar.Inventory.RemoveAt(itemIndex);
                Avatar.Location.Items.Add(item);
            }
        }
    }
}