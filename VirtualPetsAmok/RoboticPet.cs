using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    class RoboticPet : VirtualPets
    {
        int Battery;
        int Performance;

         public RoboticPet(string name, string species)  
         {
            Name = name;
            Battery = 50;
            Performance = 70;
            Boredom = 50;
            Species = species;


         }
        
        public override void CheckStatus()
        {
            Console.WriteLine("\n----------------------");
            Console.WriteLine(Name);
            Console.WriteLine("----------------------");
            Console.WriteLine("Your pet's performance level is " + Performance);
            Console.WriteLine("Your pet's boredom is " + Boredom);
            Console.WriteLine("Your pet's battery level is " + Battery);
        }
        public override void FeedPet()
        {
            Battery -= 10;
            if (Battery < 0) Battery = 0;
            Console.WriteLine("\n" + Name + "'s current battery is now " + Battery);
        }
        
        public override void DoctorPet()
        {
            if (Performance == 100)
            {
                Console.WriteLine("\n" + Name + "'s performance is already full");
            }
            else
            {
                Performance += 10;
                if (Performance > 100) Performance = 100;
                Console.WriteLine("\n" + Name + "'s current performance is now " + Performance);
            }
        }
    }
}
