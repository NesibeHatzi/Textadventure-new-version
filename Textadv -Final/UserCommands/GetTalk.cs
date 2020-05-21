using Program.UserInterface;
using Program.GameCharacters;


namespace Program.UserCommands
{
    class GetTalk : Command
    {
        
        public override void Execute(Dialog dialog, Game game)
        {
            
            dialog.GetTalk();

        }
    }
}