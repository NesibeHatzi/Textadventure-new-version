using Program.UserInterface;

namespace Program.UserCommands
{
    abstract class Command
    {
        public abstract void Execute(Dialog dialog, Game game);
    }
}