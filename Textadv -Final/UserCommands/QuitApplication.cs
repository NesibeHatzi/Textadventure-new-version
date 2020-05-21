using Program.UserInterface;

namespace Program.UserCommands
{
    class QuitApplication : Command
    {
        public override void Execute(Dialog dialog, Game game)
        {
            game.Quit();
        }
    }
}