using Moq;
using Xunit;

namespace Sparky
{
    public class BankAccountXUnitTests
    {
        private BankAccount bankAccount;
        [Fact]
        public void SetUp()
        {
            bankAccount = new(new LogBook());
        }

        [Fact]
        public void BankDeposit_Add100_ReturnTrue()
        {
            var logMoq = new Mock<ILogBook>();
            BankAccount account = new(logMoq.Object);
            var result = account.Deposit(100);
            Assert.True(result);
        }

    }
}
