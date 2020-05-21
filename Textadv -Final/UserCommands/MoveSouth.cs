using Program.GameLocations;
using Program.UserInterface;

namespace Program.UserCommands
{
    class MoveSouth : Command
    {
        public override void Execute(Dialog dialog, Game game)
        {
            var destination = game.Map.SouthOf(game.Avatar.Location);
            if (destination != null)
            {
                game.MoveAvatarToNewLocation(destination);
            }
        }
    }
}