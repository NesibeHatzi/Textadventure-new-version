using Program.UserInterface;
using Program.GameCharacters;
using System;

namespace Program.UserCommands
{
    class GetPower : Command
    {
        
        public override void Execute(Dialog dialog, Game game)
        {
            
            dialog.GetPower();

        }
    }
}