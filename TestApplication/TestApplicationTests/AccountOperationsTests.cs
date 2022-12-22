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
    public class AccountOperationsTests
    {
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void OnConstruction_ThrowsNullArgumentException_WhenDatabaseIsNullTest()
        {
            // Arrange
            IAccountData nullDatabase = null;

            // Act / Assert
            new AccountOperations(nullDatabase);
        }

        [TestMethod]
        public void GetBalanceForSingleAccount_ReturnsBalanceFromDatabase_WhenDatabaseProvidesTheAccountTest()
        {
            int accountNumber = 12345;
            int expectedBalance = 420;

            // Arrange
            var mockAccount = new Mock<IAccount>();
            mockAccount.Setup(x => x.Balance).Returns(expectedBalance);

            var mockDatabase = new Mock<IAccountData>();
            mockDatabase.Setup(x => x.GetAccount(accountNumber)).Returns(mockAccount.Object);

            var testingClass = new AccountOperations(mockDatabase.Object);

            // Act
            int actualBalance = testingClass.GetBalanceForSingleAccount(accountNumber);

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void GetBalanceForSingleAccount_ReturnsZero_WhenDatabaseProvidesTheAccountTest()
        {
            int accountNumber = 12345;
            int expectedBalance = 0;

            // Arrange
            var mockAccount = new Mock<IAccount>();

            var mockDatabase = new Mock<IAccountData>();
            mockDatabase.Setup(x => x.GetAccount(accountNumber)).Returns(mockAccount.Object);

            var testingClass = new AccountOperations(mockDatabase.Object);

            // Act
            int actualBalance = testingClass.GetBalanceForSingleAccount(accountNumber);

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void GetBalanceForSingleAccount_ReturnsZero_WhenThereIsNoAccountFoundTest()
        {
            int accountNumber = 12345;
            int expectedBalance = 0;

            // Arrange
            IAccount nullAccount = null;

            var mockDatabase = new Mock<IAccountData>();
            mockDatabase.Setup(x => x.GetAccount(accountNumber)).Returns(nullAccount);

            var testingClass = new AccountOperations(mockDatabase.Object);

            // Act
            int actualBalance = testingClass.GetBalanceForSingleAccount(accountNumber);

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }
    }
}
