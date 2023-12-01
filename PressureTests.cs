
using pressureAlarmLibary;
using Moq;

namespace TirePressureTests

{
    [TestClass]
    public class PressureTests
    {
        
        [TestMethod]
        public void PressureTooHigh()
        {
            // Arrange
            var sensorMock = new Mock<ISensor>();
            sensorMock.Setup(s => s.QueryHardwareForPsiValue()).Returns(35);
            PressureAlarm alarm = new PressureAlarm(sensorMock.Object);

            // Act
            alarm.Check();

            // Assert
            Assert.IsTrue(alarm.Alarm);
        }


        [TestMethod]
        public void PressureTooLow()
        {
            // Arrange
            var sensorMock = new Mock<ISensor>();
            sensorMock.Setup(s => s.QueryHardwareForPsiValue()).Returns(10);
            PressureAlarm alarm = new PressureAlarm(sensorMock.Object);

            // Act
            alarm.Check();

            // Assert
            Assert.IsTrue(alarm.Alarm);
        }


        [TestMethod]
        public void PressureJustRight()
        {
            // Arrange
            var sensorMock = new Mock<ISensor>();
            sensorMock.Setup(s => s.QueryHardwareForPsiValue()).Returns(25);
            PressureAlarm alarm = new PressureAlarm(sensorMock.Object);

            // Act
            alarm.Check();

            // Assert
            Assert.IsFalse(alarm.Alarm);
        }


        [TestMethod]
        public void PressureTooHighUsingDouble()
        {
            // Arrange
            SensorDouble sDOne = new SensorDouble { PsiValue = 35 };
            PressureAlarm alarm = new PressureAlarm(sDOne);

            // Act
            alarm.Check();

            // Assert
            Assert.IsTrue(alarm.Alarm);
        }

        [TestMethod]
        public void PressureTooLowUsingDouble()
        {
            // Arrange
            SensorDouble sDTwo = new SensorDouble { PsiValue = 10 };
            PressureAlarm alarm = new PressureAlarm(sDTwo);

            // Act
            alarm.Check();

            // Assert
            Assert.IsTrue(alarm.Alarm);
        }

        [TestMethod]
        public void PressureJustRightUsingDouble()
        {
            // Arrange
            SensorDouble sDThree = new SensorDouble { PsiValue = 25 };
            PressureAlarm alarm = new PressureAlarm(sDThree);

            // Act
            alarm.Check();

            // Assert
            Assert.IsFalse(alarm.Alarm);
        }



    }
}