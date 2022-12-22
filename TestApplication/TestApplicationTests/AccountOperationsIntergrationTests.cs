using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication;

namespace TestApplicationTests
{
    [TestClass]
    public class AccountOperationsIntergrationTests
    {
        [TestMethod]
        public void GetBalanceForSingleAccount_Returns3456_WhenRetrivingTheTestAccountTest()
        {
            int accountNumber = 1000;
            int expectedBalance = 3456;

            // Arrange
            IAccountData database = new AccountDatabase();

            var testingClass = new AccountOperations(database);

            // Act
            int actualBalance = testingClass.GetBalanceForSingleAccount(accountNumber);

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void GetBalanceForSingleAccount_Returns0_WhenRetrivingNonExistantAccountTest()
        {
            int accountNumber = 0;
            int expectedBalance = 0;

            // Arrange
            IAccountData database = new AccountDatabase();

            var testingClass = new AccountOperations(database);

            // Act
            int actualBalance = testingClass.GetBalanceForSingleAccount(accountNumber);

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }
    }
}
