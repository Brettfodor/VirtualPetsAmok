using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class VirtualPetShelter
    {
        public List<VirtualPets> petsInShelter = new List<VirtualPets>();
        VirtualPets myPet = new VirtualPets();
        public VirtualPetShelter()
        {

        }

        public void AddPetToShelter(VirtualPets pet)
        {
            pet.PetCreation();
        }
    }
}

        