using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
     public class VirtualPets
    {

        public string Name { get; set; }
        public bool IsOrganic { get; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        public VirtualPets (string name, string isOrganic)
        {
            Name = name;
            Hunger = 50;
            Health = 100;
            Boredom = 50;
            if (isOrganic.ToLower() == "o")
            {
                IsOrganic = true;
            }
            else if (isOrganic.ToLower() == "r")
            {
                IsOrganic = false;
            }
            
        }
    }
}
