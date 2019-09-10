using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    class Menu
    {
        public bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Virtual Pets Amok");
            Console.WriteLine("Game Menu");

            Console.WriteLine("Play Game (p)");

            Console.WriteLine("Exit Game (e)");


            string userInput = Console.ReadLine();
            Console.Clear();
            if (userInput.ToLower() == "p")
            {
                return true;
            }
            else if (userInput.ToLower() == "e")
            {
                
                Environment.Exit(1);
                
            }
            
            return false;
            
        }
    }
}
