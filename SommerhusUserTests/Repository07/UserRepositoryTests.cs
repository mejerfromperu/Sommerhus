using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Sommerhus.Model;
using Sommerhus.Repository07;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommerhus.Repository07.Tests
{
    [TestClass()]
    public class UserRepositoryTests
    {
        private UserRepository _userRepository;


        [TestInitialize]
        public void BeforeEachTest()
        {
            _userRepository = new UserRepository();
        }

        [TestMethod()]
        public void AddTest()
        {

            // Arrange
            var mockConnection = new Mock<SqlConnection>();
            var mockCommand = new Mock<SqlCommand>();

            mockConnection.Setup(x => x.Open());
            mockConnection.Setup(x => x.CreateCommand()).Returns(mockCommand.Object);

            var userRepository = new UserRepository(mockConnection.Object);

            var userToAdd = new User(/* Provide necessary user data for testing */);

            // Act
            var addedUser = _userRepository.Add(userToAdd);

            // Assert
            Assert.IsNotNull(addedUser);
            // Add more assertions based on the expected behavior of the Add method
        }

        //[TestMethod()]
        //public void DeleteTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void GetAllTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void GetByIdTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void UpdateTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void GetByEmailAndPasswordTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void SearchTest()
        //{
        //    Assert.Fail();
        //}
    }
}