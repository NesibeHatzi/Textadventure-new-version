using Program.UserInterface;

namespace Program.UserCommands
{
    class DoNothing : Command
    {
        public override void Execute(Dialog dialog, Game game)
        {
            // nothing to do
               dialog.DoNothing();
        }
    }
}