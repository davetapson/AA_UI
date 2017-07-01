using AA.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AA.ServicesTest
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void TestLoginPass()
        {
            // Arrange
            Login login;
            string userName = "test";
            string password = "test";

            // Act
            login = new Login(userName, password);

            //Assert
            // none required
        }

        [TestMethod]
        [ExpectedException (typeof(System.ArgumentException)) ]
        public void TestLoginFailNullUserName()
        {
            // Arrange
            Login login;
            string userName = null;
            string password = "test";

            // Act
            login = new Login(userName, password);

            //Assert
            // none required
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TestLoginFailEmptyUserName()
        {
            // Arrange
            Login login;
            string userName = "";
            string password = "test";

            // Act
            login = new Login(userName, password);

            //Assert
            // none required
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TestLoginFailUnrecognisedUserName()
        {
            // Arrange
            Login login;
            string userName = "wrong";
            string password = "test";

            // Act
            login = new Login(userName, password);

            //Assert
            // none required
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TestLoginFailNullPassword()
        {
            // Arrange
            Login login;
            string userName = "test";
            string password = null;

            // Act
            login = new Login(userName, password);

            //Assert
            // none required
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TestLoginFailEmptyPassword()
        {
            // Arrange
            Login login;
            string userName = "test";
            string password = "";

            // Act
            login = new Login(userName, password);

            //Assert
            // none required
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TestLoginFailUnrecognisedPassword()
        {
            // Arrange
            Login login;
            string userName = "test";
            string password = "wrong";

            // Act
            login = new Login(userName, password);

            //Assert
            // none required
        }
    }
}
