using System;

namespace VirtualPetsAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            
            Menu menu = new Menu();
            bool inGame = false;

            inGame = menu.MainMenu();

            //Playing Game
            menu.Game(inGame);
        }
    }
}
