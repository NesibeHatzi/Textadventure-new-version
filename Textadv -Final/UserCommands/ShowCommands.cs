using Program.UserInterface;

namespace Program.UserCommands
{
    class ShowCommands : Command
    {
        public override void Execute(Dialog dialog, Game game)
        {
            dialog.PrintCommands();
        }
    }
}