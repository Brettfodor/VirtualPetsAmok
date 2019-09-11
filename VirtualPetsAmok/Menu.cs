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
        public VirtualPets PetCreation()
        {
            Console.Clear();

            //Get name from user
            Console.WriteLine("What should your pet's name be?");

            string petCreationName = Console.ReadLine();

            Console.Clear();
            // Get species from user
            Console.WriteLine("What species should your pet be?");
            string petCreationSpecies = Console.ReadLine();

            Console.Clear();
            // Create Pet
           VirtualPets newPet = new VirtualPets(petCreationName, petCreationSpecies);
            Console.WriteLine("Your awesome new pet " + petCreationName + " is ready to play!");


            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();

            return newPet;
        }
    }
}
