using System;

namespace VirtualPetsAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            string userInput;
            string petCreationName;
            string petCreationSpecies;
            VirtualPets newPet = new VirtualPets();
            Menu menu = new Menu();
            bool inGame = false;

            inGame = menu.MainMenu(); 
            
            //Playing Game
            while (inGame)
            {
                //menu
                Console.WriteLine("To Return to Main Menu: type (m)");
                Console.WriteLine("To create a pet: type (c)");
                Console.WriteLine("To check your pets information: type (s)");
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "m")
                {
                    inGame = menu.MainMenu();
                }
                else if (userInput.ToLower() == "c")
                {
                    newPet = menu.PetCreation();
                }
                else if (userInput.ToLower() == "s")
                {
                    newPet.CheckInfo();
                }
            }
            Console.Clear();
           
        }
    }
}
