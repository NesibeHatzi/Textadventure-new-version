using Program.UserInterface;
using Program.GameCharacters;
using System;

namespace Program.UserCommands
{
    class PrintHelp : Command
    {
        
        public override void Execute(Dialog dialog, Game game)
        {
            
            dialog.PrintHelp();

        }
    }
}