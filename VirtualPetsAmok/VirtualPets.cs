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
            Health = 100;
            Boredom = 50;
            Species = species;
            
        }
        public VirtualPets()
        {

        }

        public void CheckInfo()
        {
            Console.Clear();
            Console.WriteLine("You pet's name is " + Name + " Your pet's species is " + Species);
            Console.ReadLine();
        }
    }
}
