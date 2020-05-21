using Program.UserInterface;

namespace Program.UserCommands
{
    class MoveWest : Command
    {
        public override void Execute(Dialog dialog, Game game)
        {
            var destination = game.Map.WestOf(game.Avatar.Location);
            if (destination != null)
            {
                game.MoveAvatarToNewLocation(destination);
            }
        }
    }
}