using Program.UserInterface;

namespace Program.UserCommands
{
    class ShowInventory : Command
    {
        public override void Execute(Dialog dialog, Game game)
        {
            dialog.PrintInventory();
        }
    }
}