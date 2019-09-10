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
            VirtualPets newPet;
            Menu menu = new Menu();
            bool inGame = false;

            inGame = menu.MainMenu();
            
            //Playing Game
            while (inGame)
            {
                //menu
                Console.WriteLine("To Return to Main Menu: type (m)");
                Console.WriteLine("To create a pet: type (c)");
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "m")
                {
                    inGame = menu.MainMenu();
                }
                else if (userInput.ToLower() == "c")
                {
                    
                    Console.Clear();

                    //Get name from user
                    Console.WriteLine("What should your pet's name be?");

                    petCreationName = Console.ReadLine();

                    Console.Clear();
                    // Get species from user
                    Console.WriteLine("What species should your pet be?");
                    petCreationSpecies  = Console.ReadLine();
                       
                    Console.Clear();
                    // Create Pet
                    newPet = new VirtualPets(petCreationName, petCreationSpecies);
                    Console.WriteLine("Your awesome new pet " + petCreationName + " is ready to play!");
                        

                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            Console.Clear();
           
        }
    }
}
