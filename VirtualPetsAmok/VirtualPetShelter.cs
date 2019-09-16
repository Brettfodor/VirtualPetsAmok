using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class VirtualPetShelter
    {
        public List<VirtualPets> petsInShelter = new List<VirtualPets>();

        public void NoticeNoPets()
        {
            Console.WriteLine("There are no pets currently in your shelter");
        }
        public void PetCreation()
        {
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
        public void AllCheckInfo()
        {
            Console.Clear();

            foreach (VirtualPets pet in petsInShelter) pet.CheckInfo();

            if (petsInShelter.Count == 0) this.NoticeNoPets();

            Console.WriteLine("\n Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
        }
        public void AllCheckStatus()
        {
            Console.Clear();

            foreach (VirtualPets pet in petsInShelter) pet.CheckStatus();

            if (petsInShelter.Count == 0) this.NoticeNoPets();

            Console.WriteLine("\n Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
        }
        public void AllFeedPet()
        {
            Console.Clear();

            foreach (VirtualPets pet in petsInShelter) pet.FeedPet();

            if (petsInShelter.Count == 0) this.NoticeNoPets();

            Console.WriteLine("\n Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
        }
        public void AllPlayPet()
        {
            Console.Clear();

            foreach (VirtualPets pet in petsInShelter) pet.PlayPet();

            if (petsInShelter.Count == 0) this.NoticeNoPets();

            Console.WriteLine("\n Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
        }
        public void AllDoctorPet()
        {
            Console.Clear();

            Console.WriteLine("\n Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

        