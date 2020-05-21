using Program.UserInterface;
using Program.GameCharacters;


namespace Program.UserCommands
{
    class NoFight : Command
    {
        
        public override void Execute(Dialog dialog, Game game)
        {
            
            dialog.NoFight();

        }
    }
}