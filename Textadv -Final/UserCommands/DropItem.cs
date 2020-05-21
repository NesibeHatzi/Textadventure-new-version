using Program.UserInterface;

namespace Program.UserCommands
{
    class DropItem : Command
    {
        private int _itemIndex;

        public DropItem(int itemIndex)
        {
            _itemIndex = itemIndex;
        }

        public override void Execute(Dialog dialog, Game game)
        {
            game.MoveItemFromAvatarToLocation(_itemIndex);
        }
    }
}