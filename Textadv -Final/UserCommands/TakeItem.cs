using Program.UserInterface;

namespace Program.UserCommands
{
    class TakeItem : Command
    {
        private int _itemIndex;

        public TakeItem(int itemIndex)
        {
            _itemIndex = itemIndex;
        }

        public override void Execute(Dialog dialog, Game game)
        {
            game.MoveItemFromLocationToAvatar(_itemIndex);
        }
    }
}