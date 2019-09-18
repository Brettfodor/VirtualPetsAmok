using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
     public class VirtualPets
    {

        public string Name { get; set; }
        public string Species { get; set;}
        
        public int Boredom { get; set; }

        public VirtualPets (string name, string species)
        {
            Name = name;
            Boredom = 50;
            Species = species;
           
            
        }
        public VirtualPets()
        {
            Name = Name;
            Boredom = 50;
            Species = Species;

        }
        public virtual void CheckInfo()
        {
            Console.WriteLine("Your Pet " + Name + " is a " + Species);
        }
        public virtual void CheckStatus()
        {
            
        }
        public virtual void FeedPet()
        {
            
        }
        public virtual void PlayPet()
        {
            Boredom -= 10;
            if (Boredom < 0) Boredom = 0;
            Console.WriteLine("\n" + Name + "'s current boredom is now " + Boredom);
        }
        public virtual void DoctorPet()
        {
            
        }
        
    }
}
