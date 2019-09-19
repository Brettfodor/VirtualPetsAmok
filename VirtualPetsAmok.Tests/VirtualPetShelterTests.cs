using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPetsAmok.Tests
{
   public class VirtualPetShelterTests
    {
        VirtualPetShelter myShelter;
        OrganicPet pet;
        public VirtualPetShelterTests()
        { myShelter = new VirtualPetShelter();
            pet = new OrganicPet("bob", "thing");
        }
        
        
        [Fact]
        public void Shelter_Exists_in_Game()
        {//Arrange
            myShelter = new VirtualPetShelter();

        }
        [Fact]
        public void Shelter_Adds_Pets()
        {
            var myShelter = new VirtualPetShelter();


        }

        [Fact]
        public void Shelter_Adopts_Pets()
        {
            VirtualPets pet = new OrganicPet("bob", "thing");

            myShelter.petsInShelter.Add(pet);
            myShelter.AdoptPet(pet);

            Assert.Empty(myShelter.petsInShelter);
        }
        [Fact]
        public void Ticktime_Changes_Pets_Hunger()
        {
            pet.TickTime();

            Assert.Equal(51, pet.Hunger);


        }
    }
}
