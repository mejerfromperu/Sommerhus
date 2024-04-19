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
        private Mock<SqlConnection> _mockConnection;
        User useryes = new User(0, "yes", "no", "maybe", "92", "84", "mike", "2", "1", 2, false, true);

        // This method will run before each test method
        [TestInitialize]
        public void BeforeEachTest()
        {
            
            _userRepository = new UserRepository();    
        }

        [TestMethod()]
        public void AddTest()
        {
            // Arrange

            // Act
            _userRepository.Add(useryes);

            // Assert
            Assert.IsNull(_userRepository);
            // Add more assertions based on the expected behavior of the Add method
        }

        // Other test methods
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
