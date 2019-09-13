using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    class Menu
    {
        public bool MainMenu()
        {
            bool inMenu = true;
            while (inMenu)
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
            }
            return false;
            
        }
        public void Game(bool inGame)
        {
            VirtualPets myShelter = new VirtualPets();
            VirtualPets newPet = new VirtualPets();
            string userInput;
            while (inGame)
            {
                //menu
                Console.WriteLine("To Return to Main Menu: type (m)");
                Console.WriteLine("To create a pet: type (c)");


                Console.WriteLine("\nInteract with pet");
                Console.WriteLine("To check your pets information: type (i)");
                Console.WriteLine("To check your pets status: type (s)");
                Console.WriteLine("To feed your pet: type (f)");
                Console.WriteLine("To play with your pet: type (p)");
                Console.WriteLine("To take your pet to the doctor: type (d)");
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "m")
                {
                    inGame = this.MainMenu();
                }
                else if (userInput.ToLower() == "c")
                {
                    myShelter.PetCreation();

                }
                else if (userInput.ToLower() == "i")
                {
                    newPet.CheckInfo();
                }
                else if (userInput.ToLower() == "s")
                {
                    newPet.CheckStatus();
                }
                else if (userInput.ToLower() == "f")
                {
                    newPet.FeedPet();
                }
                else if (userInput.ToLower() == "p")
                {
                    newPet.PlayPet();
                }
                else if (userInput.ToLower() == "d")
                {
                    newPet.DoctorPet();
                }
                Console.Clear();
            }
        }

       
    }
}
