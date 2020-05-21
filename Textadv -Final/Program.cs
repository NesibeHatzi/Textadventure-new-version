using System;
using Program.GameCharacters;
using Program.UserInterface;

namespace Program
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine ("\nWhat is your name? ");
            var name = Console.ReadLine ();
            var date = DateTime.Now;
            Console.WriteLine ($"\nHello, {name}, on {date:d} at {date:t} a very mysterious adventure is waiting for you, are you ready?!");
            Console.WriteLine ($"\nPress any key to start with the game {name}...");
            Console.ReadKey (true);
            

            var game = new Game ();
            var dialog = new Dialog (game);
            dialog.Loop ();

        }
    }
}