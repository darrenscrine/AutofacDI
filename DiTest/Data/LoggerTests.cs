using Autofac;
using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiTest.Data
{
    [TestClass]
    public class LoggerTests
    {
        private IContainer Container { get; set; }

        [TestInitialize]
        public void Initialise()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Logger>().As<ILogger>();
            Container = builder.Build();
        }

        [TestMethod]
        public void GetMessage_NotSet_ReturnsNull()
        {
            //Arrange
            var logger = Container.Resolve<ILogger>();

            //Act
            var messageReceived = logger.GetMessage();

            //Assert
            Assert.IsTrue(string.IsNullOrEmpty(messageReceived));
        }

        [TestMethod]
        public void GetMessage_LogCalled_ReturnsMessagePassed()
        {
            //Arrange
            var logger = Container.Resolve<ILogger>();
            const string loggerMessage = "Hello";
            const string expectedMessage = "Written with 'Logger':" + loggerMessage;

            //Act
            logger.Log(loggerMessage);
            var messageReceived = logger.GetMessage();

            //Assert
            Assert.AreEqual(messageReceived, expectedMessage);
        }
    }
}
