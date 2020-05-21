using Program.UserInterface;

namespace Program.UserCommands
{
    internal class ShowHealth : Command
    {
        public override void Execute(Dialog dialog, Game game)
        {
            if (game.Avatar.Location.IsMonsterAlive)
                dialog.PrintHealth();
        }
    }
}