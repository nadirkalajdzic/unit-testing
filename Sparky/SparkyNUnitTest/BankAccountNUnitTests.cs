using Moq;
using NUnit.Framework;

namespace Sparky
{
    [TestFixture]
    public class BankAccountNUnitTests
    {
        private BankAccount bankAccount;
        [SetUp]
        public void SetUp()
        {
            bankAccount = new(new LogBook());
        }

        [Test]
        public void BankDeposit_Add100_ReturnTrue()
        {
            var logMoq = new Mock<ILogBook>();
            BankAccount account = new(logMoq.Object);
            var result = account.Deposit(100);
            Assert.IsTrue(result);
            Assert.That(account.GetBalance, Is.EqualTo(100));
        }

    }
}
