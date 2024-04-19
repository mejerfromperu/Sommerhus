using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sommerhus.Model;
using Sommerhus.Repository07;
using System;
using System.Collections.Generic;
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

            User userToAdd = new User();

            _userRepository.Add(userToAdd);


            Assert.IsNull(_userRepository);
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