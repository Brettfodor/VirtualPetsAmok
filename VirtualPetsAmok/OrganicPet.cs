using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    class OrganicPet : VirtualPets
    {
        public int Hunger { get; set; }
        public int Health { get; set; }


        public OrganicPet(string name, string species)
        {
            Name = name;
            Hunger = 50;
            Health = 70;
            Boredom = 50;
            Species = species;


        }
        
        public override void CheckStatus()
        {
            Console.WriteLine("\n----------------------");
            Console.WriteLine(Name);
            Console.WriteLine("----------------------");
            Console.WriteLine("Your pet's health is " + Health);
            Console.WriteLine("Your pet's boredom is " + Boredom);
            Console.WriteLine("Your pet's Hunger is " + Hunger);
        }
        public override void FeedPet()
        {
            Hunger -= 10;
            if (Hunger < 0) Hunger = 0;
            Console.WriteLine("\n" + Name + "'s current hunger is now " + Hunger);
        }
        
        public override void DoctorPet()
        {
            if (Health == 100)
            {
                Console.WriteLine("\n" + Name + "'s health is already full");
            }
            else
            {
                Health += 10;
                if (Health > 100) Health = 100;
                Console.WriteLine("\n" + Name + "'s current health is now " + Health);
            }
        }
        public override void TickTime()
        {
            this.Boredom++;
            this.Hunger++;
            this.Health--;
        }
    }
}
