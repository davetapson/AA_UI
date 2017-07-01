using System;
using AA.Services;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Principal;

namespace AA.ServicesTest
{
    [TestClass]
    public class AccountTests
    {

        [TestMethod]
        public void CreateAccount_WithRequiredFieldsMustPass()
        {
            // Arrange
            Account account;
            string accountNumber = "A1";

            // Act
            account = new Account(accountNumber);

            //Assert
            Assert.AreEqual(accountNumber, account.AccountNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void CreateAccount_WithMissingRequiredFieldsMustFail()
        {
            // Arrange
            
            // Act
            Account account = new Account(null);

            //Assert
        }

    }
}
