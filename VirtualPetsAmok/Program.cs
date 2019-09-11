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
            //Main Menu

            inGame = menu.MainMenu();

            //Playing Game
            menu.Game(inGame);
        }
    }
}
