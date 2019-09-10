using System;
using Xunit;

namespace VirtualPetsAmok.Tests
{
    public class VirtualPetsAmokTests
    {
        [Fact]
        public void Can_Create_Pet_Instance()
        {
            new VirtualPets("Mink","o");

        }
        [Fact]
        public void Pet_Has_Name()
        {
            // Arrange 
          var myPet =  new VirtualPets("Mink", "o");

            //Act
            myPet.Name = "Rainbow";

            // Assert
            Assert.Equal("Rainbow", myPet.Name);

        }
        [Fact]
        public void Pet_Has_Hunger()
        {
            // Arrange 
            var myPet = new VirtualPets("Mink", "o");

            //Act
            myPet.Hunger = 40;

            // Assert
            Assert.Equal(40, myPet.Hunger);

        }
        [Fact]
        public void Pet_Has_Boredom()
        {
            // Arrange 
            var myPet = new VirtualPets("Mink", "o");

            //Act
            myPet.Boredom = 40;

            // Assert
            Assert.Equal(40, myPet.Boredom);

        }
        [Fact]
        public void Pet_Has_Health()
        {
            // Arrange 
            var myPet = new VirtualPets("Mink", "o");

            //Act
            myPet.Health = 40;

            // Assert
            Assert.Equal(40, myPet.Health);

        }
    }
}
