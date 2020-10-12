using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
namespace UserMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(true,"Mukesh")]
        [DataRow(true, "Attuluri")]

        public void TestName(bool expected,string name )
        {//Arrange
            
            //Act
            bool actual = User.ValidateName(name);
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
            bool actual = User.ValidatePhoneNumber("91 8978496720");
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
        [DataTestMethod]
        [DataRow(true, "abc@yahoo.com")]
        [DataRow(true, "abc-100@yahoo.com")]
        [DataRow(true, "abc.100@yahoo.com")]
        [DataRow(true, "abc111@abc.com")]
        [DataRow(true, "abc-100@abc.net")]
        [DataRow(true, "abc+100@gmail.com")]
        [DataRow(true, "abc123@gmail.1a")]
        [DataRow(true, "abc@1.com")]
        [DataRow(true, "abc@.com.my")]
        [DataRow(true, "abc123@.com.com")]
        public void TestMultipleEmails(bool expected,string email)
        {//Arrange
           
            //Act
            bool actual = User.ValidateEmail(email);
            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
