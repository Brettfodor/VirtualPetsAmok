using System;
using Xunit;

namespace VirtualPetsAmok.Tests
{
    public class VirtualPetsAmokTests
    {
        OrganicPet opet;
        public VirtualPetsAmokTests()
        {
            opet = new OrganicPet("bob", "thing");
        }
        [Fact]
        public void Can_Create_Pet_Instance()
        {
            new VirtualPets();

        }
        [Fact]
        public void Pet_Has_Name()
        {
            // Arrange 
            var myPet = new VirtualPets();

            //Act
            myPet.Name = "Rainbow";

            // Assert
            Assert.Equal("Rainbow", myPet.Name);

        }
        [Fact]
        public void Organic_Pet_Has_Hunger()
        {
            // Arrange 
            var myPet = new OrganicPet("bob", "species");

            //Act
            myPet.Hunger = 40;

            // Assert
            Assert.Equal(40, myPet.Hunger);

        }
        [Fact]
        public void Pet_Has_Boredom()
        {
            // Arrange 
            var myPet = new VirtualPets();

            //Act
            myPet.Boredom = 40;

            // Assert
            Assert.Equal(40, myPet.Boredom);

        }
        [Fact]
        public void Pet_Has_Health()
        {
            // Arrange 
            var myPet = new OrganicPet("bob", "species");

            //Act
            myPet.Health = 40;

            // Assert
            Assert.Equal(40, myPet.Health);
        }
        [Fact]
        public void Can_Feed_Pet()
        {
            // Arrange 


            //Act
            opet.FeedPet();

            // Assert
            Assert.Equal(40, opet.Hunger);
        }
        [Fact]
        public void Can_Take_Pet_ToDoctor()
        {
            // Arrange 


            //Act
            opet.DoctorPet();

            // Assert
            Assert.Equal(80, opet.Health);

        }
    }
}
