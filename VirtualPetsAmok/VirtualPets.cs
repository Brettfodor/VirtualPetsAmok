using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
     public class VirtualPets
    {

        public string Name { get; set; }
        public string Species { get; set;}
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        public VirtualPets (string name, string species)
        {
            Name = name;
            Hunger = 50;
            Health = 70;
            Boredom = 50;
            Species = species;
           
            
        }
        public VirtualPets()
        {
            Name = Name;
            Hunger = 50;
            Health = 70;
            Boredom = 50;
            Species = Species;

        }
        public void CheckInfo()
        {
            Console.WriteLine("Your Pet " + Name + " is a " + Species);
        }
        public void CheckStatus()
        {
            Console.WriteLine("\n----------------------");
            Console.WriteLine(Name);
            Console.WriteLine("----------------------");
            Console.WriteLine("Your pet's health is " + Health);
            Console.WriteLine("Your pet's boredom is " + Boredom);
            Console.WriteLine("Your pet's Hunger is " + Hunger);
        }
        public void FeedPet()
        {
            Hunger -= 10;
            if (Hunger < 0) Hunger = 0;
            Console.WriteLine(Name + "'s current hunger is now " + Hunger);
            Console.WriteLine("\n Press 'Enter' to continue");
        }
        public void PlayPet()
        {
            Boredom -= 10;
            if (Boredom < 0) Boredom = 0;
            Console.WriteLine(Name + "'s current boredom is now " + Boredom);
            Console.WriteLine("\n Press 'Enter' to continue");
        }
        public void DoctorPet()
        {
            if(Health == 100)
            {
                Console.WriteLine(Name + "'s health is already full");
                Console.WriteLine("\n Press 'Enter' to continue");
            }
            else
            {
                Health += 10;
                if (Health > 100) Health = 100;
                Console.WriteLine(Name + "'s current health is now " + Health);
                Console.WriteLine("\n Press 'Enter' to continue");
            }
        }

    }
}
