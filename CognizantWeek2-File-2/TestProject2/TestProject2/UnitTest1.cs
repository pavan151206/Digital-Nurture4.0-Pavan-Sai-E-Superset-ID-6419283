using TestProject2;
using Moq;
using NUnit.Framework;
using TestProject2;

namespace TestProject2.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        [Test]
        public void SendMailToCustomer_ShouldReturnTrue_WhenMailIsSent()
        {
            
            var mockMailSender = new Mock<IMailSender>();
            mockMailSender.Setup(ms => ms.SendMail(It.IsAny<string>(), It.IsAny<string>())).Returns(true);

            
            var customerComm = new CustomerComm(mockMailSender.Object);

            
            var result = customerComm.SendMailToCustomer();

            
            Assert.IsTrue(result);

            
            mockMailSender.Verify(ms => ms.SendMail(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }
    }
}
