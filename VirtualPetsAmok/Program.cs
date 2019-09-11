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
                
                Console.WriteLine("\nInteract with pet");
                Console.WriteLine("To check your pets information: type (i)");
                Console.WriteLine("To check your pets status: type (s)");
                Console.WriteLine("To feed your pet: type (f)");
                Console.WriteLine("To play with your pet: type (p)");
                Console.WriteLine("To take your pet to the doctor: type (d)");
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "m")
                {
                    inGame = menu.MainMenu();
                }
                else if (userInput.ToLower() == "c")
                {
                    newPet = menu.PetCreation();
                }
                else if (userInput.ToLower() == "i")
                {
                    newPet.CheckInfo();
                }
                else if(userInput.ToLower() == "s")
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
            }
            Console.Clear();
           
        }
    }
}
