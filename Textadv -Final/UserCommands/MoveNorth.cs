using Program.UserInterface;

namespace Program.UserCommands
{
    class MoveNorth : Command
    {
        public override void Execute(Dialog dialog, Game game)
        {
            var destination = game.Map.NorthOf(game.Avatar.Location);
            if (destination != null)
            {
                game.MoveAvatarToNewLocation(destination);
            }
        }
    }
}