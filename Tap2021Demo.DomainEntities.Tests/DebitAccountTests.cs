using System;
using Moq;
using NUnit.Framework;

namespace Tap2021Demo.DomainEntities.Tests
{
    public class DebitAccountTests
    {
        private DebitAccount Account { get; set; }

        private Mock<IWithdrawalAmountCalculator> AmountCalculator { get; set; }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenAmountWithdrawnIsInvalidShouldThrowException()
        {
            // Arrange
            var balance = (decimal)(new Random().Next());
            AmountCalculator = new Mock<IWithdrawalAmountCalculator>();
            AmountCalculator.Setup(_ => _.CalculateWithdrawalAmount(It.IsAny<decimal>(), It.IsAny<decimal>()))
                .Returns(balance + 1);
            Account = new DebitAccount(string.Empty, 0m, null);
            Account.AmountCalculator = AmountCalculator.Object;
            var exceptionThrown = false;

            // Act
            try
            {
                Account.Withdraw(new Random().Next());
            }
            catch (InvalidOperationException)
            {
                exceptionThrown = true;
            }

            // Assert
            Assert.IsTrue(exceptionThrown);
        }
    }
}