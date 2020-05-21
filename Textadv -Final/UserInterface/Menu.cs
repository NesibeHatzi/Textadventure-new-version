    using Program.UserCommands;
    

namespace Program.UserInterface
{
    class Menu
    {
        public Command GetCommandFromInput(string input)
        {
            // game-related commands
            if (input == "q") return new QuitApplication();

            // movement-related commands
            if (input == "n") return new MoveNorth();
            if (input == "e") return new MoveEast();
            if (input == "w") return new MoveWest();
            if (input == "s") return new MoveSouth();
            
            // dialog-related commands
            if (input == "h") return new PrintHelp();
            if (input == "c") return new ShowCommands();
            if (input == "l") return new LookAround(); 
            
            // item-related commands
            if (input == "i") return new ShowInventory();

            //fight-related commands
            if (input == "f") return new ShowHealth();
            if (input == "p") return new GetPower();
            if (input == "o") return new GetTalk();
            if (input == "x") return new NoFight();

            

            // take item-number, e.g: t 0
            if (input.StartsWith("t"))
            {
                var parts = input.Split();
                if (parts.Length == 2)
                {
                    int itemIndex = int.Parse(parts[1]);
                    return new TakeItem(itemIndex);
                }
            }

            // drop item-number, e.g: d 0
            if (input.StartsWith("d"))
            {
                var parts = input.Split();
                if (parts.Length == 2)
                {
                    int itemIndex = int.Parse(parts[1]);
                    return new DropItem(itemIndex);
                }
            }

          
           
            // invalid input 
            return new DoNothing();
        }
    }
}