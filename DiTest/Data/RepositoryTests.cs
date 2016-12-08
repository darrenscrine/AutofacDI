using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiTest.Data
{
    [TestClass]
    public class RepositoryTests
    {
        [TestInitialize]
        public void Initialise()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Logger>().As<ILogger>();
            builder.RegisterType<Repository>().As<IRepository>();
            builder.Build();
        }

        [TestMethod]
        public void Load_MessageText_IsCorrect()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            IRepository repository = new Repository(loggerMock.Object);

            //Act
            repository.Load();
            var receivedMessage = repository.GetMessage();
            
            //Assert
            Assert.AreEqual("Called from load", receivedMessage);
        }

        [TestMethod]
        public void Load_LoggerCalledCorrecty_CalledOnce()
        {
            //Arrange
            const string messageSent = "Called from load";
            var loggerMock = new Mock<ILogger>();
            IRepository repository = new Repository(loggerMock.Object);

            //Act
            repository.Load();
            
            //Assert
            loggerMock.Verify(logger => logger.Log(messageSent), Times.Exactly(1));
        }

        [TestMethod]
        public void Load_LoggerCalledCorrecty_CalledWithCorrectMessage()
        {
            //Arrange
            const string messageSent = "Called from load";
            var loggerMock = new Mock<ILogger>();
            IRepository repository = new Repository(loggerMock.Object);

            //Act
            repository.Load();

            //Assert
            loggerMock.Verify(logger => logger.Log(messageSent));
        }

        [TestMethod]
        public void Load_MessageSet_SetCorrectly()
        {
            //Arrange
            const string messageSent = "Called from load";
            var loggerMock = new Mock<ILogger>();
            IRepository repository = new Repository(loggerMock.Object);

            //Act
            repository.Load();

            //Assert
            Assert.AreEqual(messageSent, repository.GetMessage());
        }

        [TestMethod]
        public void Clear_MessageSet_SetCorrectly()
        {
            //Arrange
            const string messageSent = "Called from clear";
            var loggerMock = new Mock<ILogger>();
            IRepository repository = new Repository(loggerMock.Object);

            //Act
            repository.Clear();

            //Assert
            Assert.AreEqual(messageSent, repository.GetMessage());
        }

        [TestMethod]
        public void Save_MessageSet_SetCorrectly()
        {
            //Arrange
            const string messageSent = "Called from save";
            var loggerMock = new Mock<ILogger>();
            IRepository repository = new Repository(loggerMock.Object);

            //Act
            repository.Save();

            //Assert
            Assert.AreEqual(messageSent, repository.GetMessage());
        }

        [TestMethod]
        public void Clear_LoggerCalledCorrecty_CalledWithCorrectMessage()
        {
            //Arrange
            const string messageSent = "Called from clear";
            var loggerMock = new Mock<ILogger>();
            IRepository repository = new Repository(loggerMock.Object);
            //Act
            repository.Clear();

            //Assert
            loggerMock.Verify(logger => logger.Log(messageSent));
        }

        [TestMethod]
        public void Save_LoggerCalledCorrecty_CalledWithCorrectMessage()
        {
            //Arrange
            const string messageSent = "Called from save";
            var loggerMock = new Mock<ILogger>();
            IRepository repository = new Repository(loggerMock.Object);

            //Act
            repository.Save();

            //Assert
            loggerMock.Verify(logger => logger.Log(messageSent));
        }

        [TestMethod]
        public void Save_LoggerCalledCorrecty_CalledOnce()
        {
            //Arrange
            const string messageSent = "Called from save";
            var loggerMock = new Mock<ILogger>();
            IRepository repository = new Repository(loggerMock.Object);

            //Act
            repository.Save();

            //Assert
            loggerMock.Verify(logger => logger.Log(messageSent), Times.Exactly(1));
        }

        [TestMethod]
        public void GetMessage_MessageNotSet_ReturnsNull()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            IRepository repository = new Repository(loggerMock.Object);

            //Act
            var messageReceived = repository.GetMessage();

            //Assert
            Assert.IsTrue(string.IsNullOrEmpty(messageReceived));
        }
    }
}
