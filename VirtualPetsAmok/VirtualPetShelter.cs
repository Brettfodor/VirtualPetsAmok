using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class VirtualPetShelter
    {
        public void PetCreation()
        {
            //


            Console.Clear();

            //Get name from user
            Console.WriteLine("What should your pet's name be?");

            string Name = Console.ReadLine();

            Console.Clear();
            // Get species from user

            Console.WriteLine("What species should your pet be?");

            string Species = Console.ReadLine();

            Console.Clear();
            // Create Pet

            VirtualPets myPet = new VirtualPets(Name, Species);

            petsInShelter.Add(myPet);

            Console.WriteLine("Your awesome new pet " + Name + " is ready to play!");


            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();


        }

        public List<VirtualPets> petsInShelter = new List<VirtualPets>();


    }
}
