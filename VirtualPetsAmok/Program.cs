using System;

namespace VirtualPetsAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            string userInput;
            bool petCreation = false;
            string petCreationName;
            string petCreationSpecies;
            VirtualPets newPet;
            bool inGame = false;

            while (1 == 1)
            {
                //Game menu
                while (inGame == false)
                {

                    Console.WriteLine("Virtual Pets Amok");
                    Console.WriteLine("Game Menu");

                    Console.WriteLine("Play Game (p)");

                    Console.WriteLine("Exit Game (e)");


                    userInput = Console.ReadLine();
                    if (userInput.ToLower() == "p")
                    {
                        inGame = true;
                    }
                    if (userInput.ToLower() == "e")
                    {
                        Environment.Exit(1);
                    }

                }

                Console.Clear();

                //Playing Game
                while (inGame)
                {
                    //menu
                    Console.WriteLine("To Return to Main Menu: type (m)");
                    Console.WriteLine("To create a pet: type (c)");
                    userInput = Console.ReadLine();
                    if (userInput.ToLower() == "m")
                    {
                        inGame = false;
                    }
                    //Create Pet Process
                    
                    if (userInput.ToLower() == "c")
                    {
                        petCreation = true;
                    }
                    while (petCreation)
                    {
                        Console.Clear();

                        //Get name from user
                        Console.WriteLine("What should your pet's name be?");

                        userInput = Console.ReadLine();

                        petCreationName = userInput;
                        Console.Clear();
                        // Get species from user
                        Console.WriteLine("What species should your pet be? (type 'o' for organic or 'r' for robot");
                        userInput = Console.ReadLine();
                        petCreationSpecies = userInput;
                        Console.Clear();
                        // Create Pet
                        newPet = new VirtualPets(petCreationName, petCreationSpecies);
                        Console.WriteLine("Your awesome new pet " + petCreationName + " is ready to play!");
                        petCreation = false;

                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                Console.Clear();
            }
        }
    }
}
