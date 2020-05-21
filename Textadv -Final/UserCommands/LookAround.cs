using Program.UserInterface;

namespace Program.UserCommands
{
    class LookAround : Command
    {
        public override void Execute(Dialog dialog, Game game)
        {
            dialog.PrintSituation();
        }
    }
}