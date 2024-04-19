using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sommerhus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommerhus.Model.Tests
{
    [TestClass()]
    public class UserTests
    {
        private User _user;

        [TestInitialize]

        public void BeforeEachTest()
        {
            _user = new User(7, "jimmy", "john", "chris@gmail.com", "chris", "911", "jimmystreet", "420", "1", 4000, false, true );
        }

        [TestMethod()]
        public void UserConstructerTest()
        {
            Assert.AreEqual(true, _user.IsAdmin) ;
        }

        [TestMethod()]
        public void UserIdTest()
        {

            int expectedUserID = 0;

            Assert.AreEqual(expectedUserID, _user.Id);
        }


    }
}