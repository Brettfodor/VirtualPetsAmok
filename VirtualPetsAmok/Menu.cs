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
            VirtualPetShelter myShelter = new VirtualPetShelter();
            string userInput;
            while (inGame)
            {
                //menu
                Console.WriteLine("To Return to Main Menu: type (m)");
                Console.WriteLine("To create a pet: type (c)");
                Console.WriteLine("To select an individual pet; type (!)");

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
                    myShelter.AllCheckInfo();
                }
                else if (userInput.ToLower() == "s")
                {
                    myShelter.AllCheckStatus();
                }
                else if (userInput.ToLower() == "f")
                {
                    myShelter.AllFeedPet();
                }
                else if (userInput.ToLower() == "p")
                {
                    myShelter.AllPlayPet();
                }
                else if (userInput.ToLower() == "d")
                {
                    myShelter.AllDoctorPet();
                }
                else if (userInput.ToLower() == "!")
                {
                    
                   VirtualPets selectedPet = this.SelectPet(myShelter);
                    this.InteractWithSelectedPet(selectedPet, myShelter);
                }
                Console.Clear();
            }

            
        }
        public VirtualPets SelectPet(VirtualPetShelter myShelter)
        {
            int i = 1;

            Console.WriteLine("Please choose the number of the pet you'd like to interact with");
            foreach (VirtualPets pets in myShelter.petsInShelter)

            {
                Console.WriteLine($"{i}. {pets.Name}");
                i++;
            }
            int userInput = Convert.ToInt32(Console.ReadLine());

            VirtualPets selectedPet = myShelter.petsInShelter[userInput - 1];

            return selectedPet;
        }
        public void InteractWithSelectedPet(VirtualPets selectedPet, VirtualPetShelter myShelter)
        {if (selectedPet is RoboticPet)
            {
                Console.WriteLine("\nInteract with pet");
                Console.WriteLine("To check your pets information: type (i)");
                Console.WriteLine("To check your pets status: type (s)");
                Console.WriteLine("To charge your pet's battery: type (f)");
                Console.WriteLine("To play with your pet: type (p)");
                Console.WriteLine("To take your pet to the mechanic: type (d)");
                Console.WriteLine("To offer the pet up for adoption: type (a)");
            }
         else
            {
                Console.WriteLine("\nInteract with pet");
                Console.WriteLine("To check your pets information: type (i)");
                Console.WriteLine("To check your pets status: type (s)");
                Console.WriteLine("To feed your pet: type (f)");
                Console.WriteLine("To play with your pet: type (p)");
                Console.WriteLine("To take your pet to the doctor: type (d)");
                Console.WriteLine("To offer the pet up for adoption: type (a)");

            }

            string userInput = Console.ReadLine();
            
            
           
            if (userInput.ToLower() == "i")
            {
                Console.Clear();
                selectedPet.CheckInfo();
                Console.WriteLine("\nPress 'Enter' to continue");
                Console.ReadLine();

            }
            else if (userInput.ToLower() == "s")
            {
                Console.Clear();
                selectedPet.CheckStatus();
                Console.WriteLine("\nPress 'Enter' to continue");
                Console.ReadLine();
            }
            else if (userInput.ToLower() == "f")
            {
                Console.Clear();
                selectedPet.FeedPet();
                Console.WriteLine("\nPress 'Enter' to continue");
                Console.ReadLine();
            }
            else if (userInput.ToLower() == "p")
            {
                Console.Clear();
                selectedPet.PlayPet();
                Console.WriteLine("\nPress 'Enter' to continue");
                Console.ReadLine();
            }
            else if (userInput.ToLower() == "d")
            {
                Console.Clear();
                selectedPet.DoctorPet();
                Console.WriteLine("\nPress 'Enter' to continue");
                Console.ReadLine();
            }
            else if (userInput.ToLower() == "a")
            {
                Console.Clear();
                myShelter.AdoptPet(selectedPet);
                Console.WriteLine("\nPress 'Enter' to continue");
                Console.ReadLine();
            }

            Console.Clear();
        }

    }
}
