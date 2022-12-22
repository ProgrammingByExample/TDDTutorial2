using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using TestApplication;

namespace TestApplicationTests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void Balance_ReturnsZero_WhenANewAccountIsCreatedTest()
        {
            // Arrange
            var newAccount = new Account();

            // Act
            int balance = newAccount.Balance;

            // Assert
            Assert.AreEqual(0, balance);
        }

        [TestMethod]
        public void Overdraft_ReturnsZero_WhenANewAccountIsCreatedTest()
        {
            // Arrange
            var newAccount = new Account();

            // Act
            int overdraft = newAccount.Overdraft;

            // Assert
            Assert.AreEqual(0, overdraft);
        }

        [TestMethod]
        public void Balance_ReturnsZero_WhenOverdraftAndBalanceAreZeroAnd100IsTakenTest()
        {
            // Arrange
            var newAccount = new Account();

            // Act
            newAccount.Balance -= 100;
            int balance = newAccount.Balance;

            // Assert
            Assert.AreEqual(0, balance);
        }

        [TestMethod]
        public void Balance_Returns100_When100IsAddedToABlankBalanceTest()
        {
            // Arrange
            var newAccount = new Account();

            // Act
            newAccount.Balance += 100;
            int balance = newAccount.Balance;

            // Assert
            Assert.AreEqual(100, balance);
        }

        [TestMethod]
        public void Balance_ReturnsMinus100_WhenBalanceIsZeroAndOverdraftIs100And100IsTakenFromBalanceTest()
        {
            int expectedValue = -100;

            // Arrange
            var newAccount = new Account();
            newAccount.Overdraft = 100;

            // Act
            newAccount.Balance -= 100;
            int balance = newAccount.Balance;

            // Assert
            Assert.AreEqual(expectedValue, balance);
        }

        [TestMethod]
        public void Balance_ReturnsMinus50_WhenBalanceIsZeroAndOverdraftIs100And50IsTakenFromBalanceTest()
        {
            int expectedValue = -50;

            // Arrange
            var newAccount = new Account();
            newAccount.Overdraft = 100;

            // Act
            newAccount.Balance -= 50;
            int balance = newAccount.Balance;

            // Assert
            Assert.AreEqual(expectedValue, balance);
        }

        [TestMethod]
        public void Balance_ReturnsMinus100_WhenBalanceIsZeroAndOverdraftIs100And200IsTakenFromBalanceTest()
        {
            int expectedValue = -100;
            int takenFromBalance = 200;

            // Arrange
            var newAccount = new Account();
            newAccount.Overdraft = 100;

            // Act
            newAccount.Balance -= takenFromBalance;
            int balance = newAccount.Balance;

            // Assert
            Assert.AreEqual(expectedValue, balance);
        }
    }
}