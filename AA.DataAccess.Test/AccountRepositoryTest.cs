using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AA.Services;
using AA.DataAccess;

namespace AA.DataAccess.Test
{
    [TestClass]
    public class AccountRepositoryTest
    {
        [TestMethod]
        public void AccountRepository_GetAccount()
        {
            // Arrange
            AccountRepository accountRepository = new AccountRepository();
            Account account;
            string accountNumber = "1";

            // Act
            account = accountRepository.Get(accountNumber);           

            //Assert
            Assert.AreEqual(accountNumber, account.AccountNumber);

        }
    }
}
