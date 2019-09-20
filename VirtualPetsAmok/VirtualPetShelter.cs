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
            // Get pet type from user
            Console.WriteLine("Should your pet be Organic or Robotic? (type 'o' for Organic or 'r' for Robotic)");
            string type = Console.ReadLine();
            //Get name from user
            Console.Clear();
            Console.WriteLine("What should your pet's name be?");

            string Name = Console.ReadLine();

            Console.Clear();
            // Get species from user

            Console.WriteLine("What species should your pet be?");

            string Species = Console.ReadLine();

            Console.Clear();
            // Create Pet

            VirtualPets mypet;
            if(type == "o")
            {
                 mypet = new OrganicPet(Name, Species);
            }
            else
            {
                 mypet = new RoboticPet(Name, Species);
            }

            petsInShelter.Add(mypet);

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

            foreach (VirtualPets pet in petsInShelter) pet.DoctorPet();

            if (petsInShelter.Count == 0) this.NoticeNoPets();

            Console.WriteLine("\n Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
        }
        public void AdoptPet(VirtualPets selectedPet)
        {
            petsInShelter.Remove(selectedPet);
            Console.WriteLine($"{selectedPet.Name} is gone forever");
        }
        public void TickTime()
        {
            foreach (VirtualPets pet in petsInShelter) pet.TickTime();
        }
    }
}

        