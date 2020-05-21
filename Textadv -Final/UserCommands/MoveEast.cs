using Program.UserInterface;

namespace Program.UserCommands
{
    class MoveEast : Command
    {
        public override void Execute(Dialog dialog, Game game)
        {
            var destination = game.Map.EastOf(game.Avatar.Location);
            if (destination != null)
            {
                game.MoveAvatarToNewLocation(destination);
            }
        }
    }
}