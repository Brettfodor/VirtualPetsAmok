﻿using System;
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

        public VirtualPets ()
        {
           
            Hunger = 50;
            Health = 70;
            Boredom = 50;
           
            
        }
        public void PetCreation()
        {
            Console.Clear();

            //Get name from user
            Console.WriteLine("What should your pet's name be?");

             this.Name = Console.ReadLine();

            Console.Clear();
            // Get species from user
            Console.WriteLine("What species should your pet be?");
            this.Species = Console.ReadLine();

            Console.Clear();
            // Create Pet
            
            Console.WriteLine("Your awesome new pet " + this.Name + " is ready to play!");


            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();

            
        }
        public void CheckInfo()
        {
            Console.Clear();
            Console.WriteLine("Your pet's name is \"" + Name + "\" Your pet's species is " + Species);
            Console.WriteLine("\n Press 'Enter' to continue");
            Console.ReadLine();
        }
        public void CheckStatus()
        {
            Console.Clear();
            Console.WriteLine("Your pet's health is " + Health);
            Console.WriteLine("Your pet's boredom is " + Boredom);
            Console.WriteLine("Your pet's Hunger is " + Hunger);
            Console.WriteLine("\n Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
        }
        public void FeedPet()
        {
            Console.Clear();
            Hunger -= 10;
            if (Hunger < 0) Hunger = 0;
            Console.WriteLine(Name + "'s current hunger is now " + Hunger);
            Console.WriteLine("\n Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
        }
        public void PlayPet()
        {
            Console.Clear();
            Boredom -= 10;
            if (Boredom < 0) Boredom = 0;
            Console.WriteLine(Name + "'s current boredom is now " + Boredom);
            Console.WriteLine("\n Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
        }
        public void DoctorPet()
        {
            Console.Clear();
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
            Console.ReadLine();
            Console.Clear();
        }

    }
}
