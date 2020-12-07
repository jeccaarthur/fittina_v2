using System;
using FitTinaV2.Models;
using FitTinaV2.Repositories;
using FitTinaV2.Controllers;
using System.Linq;
using Xunit;

namespace FitTinaTests
{
    public class UserTests
    {
        [Fact]
        // test adding new user
        public void AddUserTest()
        {
            // arrange
            var fakeRepo = new FakeUserRepository();
            var controller = new UserController(fakeRepo);
            var user = new User()
            {
                Name = "Test Name",
                Age = 30,
                Feet = 5,
                Inches = 4,
                Weight = 150,
                FitnessGoal = "Test goal",
                EquipmentPref = "Dumbbells"
            };

            // act
            controller.CreateProfile(user);

            // assert
            // get new user from db
            var userFromDb = fakeRepo.Users.ToList()[0];
            Assert.Equal("Test Name", userFromDb.Name);

            // make sure height conversion is working
            Assert.Equal(64, userFromDb.Height);
        }


        [Fact]
        // test getting user by name
        public void TestGetUserByName()
        {
            // arrange
            var fakeRepo = new FakeUserRepository();
            var controller = new UserController(fakeRepo);
            var user = new User()
            {
                Name = "Test Name",
                Age = 30,
                Feet = 5,
                Inches = 4,
                Weight = 150,
                FitnessGoal = "Test goal",
                EquipmentPref = "Dumbbells"
            };

            // act
            controller.CreateProfile(user);

            // assert
            var userFromDb = fakeRepo.GetUserByName(user.Name);
            Assert.Equal("Test Name", userFromDb.Name);
        }
    }
}
