using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
namespace UserMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestName()
        {//Arrange
            bool expected = true;
            //Act
            bool actual = User.ValidateName("Muk");
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestEmail()
        {//Arrange
            bool expected = true;
            //Act
            bool actual = User.ValidateEmail("mkh@gmail.com");
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestPhoneNUmber()
        {//Arrange
            bool expected = true;
            //Act
            bool actual = User.ValidatePhoneNumber("8978496720");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPassword()
        {//Arrange
            bool expected = true;
            //Act
            bool actual = User.ValidatePhoneNumber("Mkh15119@");
            //Assert
            Assert.AreEqual(expected, actual);
        }




    }
}
