using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexUsingLamda;
using System;

namespace UnitTestForRegexUsingLamda
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("FirstName")]
        public void FistNameValidationReturnTrue()
        {
            //Arrange
            string firstName = "Sai";
            //Act
            bool result = RegexValidation.ValidatingFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [TestCategory("FirstName")]
        public void FistNameValidationReturnCustomException()
        {
            try
            {
                //Arrange
                string firstName = "sai";
                //Act
                bool result = RegexValidation.ValidatingFirstName(firstName);
            }
            catch(InvalidCustomException ex)
            {
                //Assert
                Assert.AreEqual("Invalid First Name", ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("LastName")]
        public void LastNameValidationReturnTrue()
        {
            //Arrange
            string lastName = "Kumar";
            //Act
            bool result = RegexValidation.ValidatingLastName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [TestCategory("LastName")]
        public void LastNameValidationReturnCustomException()
        {
            try
            {
                //Arrange
                string lastName = "kumar";
                //Act
                bool result = RegexValidation.ValidatingLastName(lastName);
            }
            catch(InvalidCustomException ex)
            {
                //Assert
                Assert.AreEqual("Invalid Last Name", ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Email")]
        public void EmailIdValidationReturnTrue()
        {
            //Arrange
            string email = "abc@gmail.com";
            //Act
            bool result = RegexValidation.ValidatingEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [TestCategory("Email")]
        public void EmailIdValidationReturnCustomException()
        {
            try
            {
                //Arrange
                string email = "abc@gmail.com.1a";
                //Act
                bool result = RegexValidation.ValidatingEmail(email);
            }
            catch(InvalidCustomException ex)
            {
                //Assert
                Assert.AreEqual("Invalid Email", ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("MobileNumber")]
        public void MobileNumberValidationReturnTrue()
        {
            //Arrange
            string mobileNumber = "91 9866201448";
            //Act
            bool result = RegexValidation.ValidatingMobileNumber(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [TestCategory("MobileNumber")]
        public void MobileNumberValidationReturnCustomValidation()
        {
            try
            {
                //Arrange
                string mobileNumber = "91 70958212634";
                //Act
                bool result = RegexValidation.ValidatingMobileNumber(mobileNumber);
            }
            catch(InvalidCustomException ex)
            {
                //Assert
                Assert.AreEqual("Invalid Mobile Number", ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Password")]
        public void PasswordValidationReturnTrue()
        {
            //Arrange
            string password = "awsvWf&2";
            //Act
            bool result = RegexValidation.ValidatingPassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [TestCategory("Password")]
        public void PasswordValidationReturnCustomValidation()
        {
            try
            {
                //Arrange
                string password = "Bran*raf";
                //Act
                bool result = RegexValidation.ValidatingPassword(password);
            }
            catch(InvalidCustomException ex)
            {
                //Assert
                Assert.AreEqual("Invalid Password", ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Parameterised Testing")]
        [DataRow("abc@gmail.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc.100@abc.com.au")]
        public void MultipleEmailIdValidationReturnTrue(string email)
        {
            Assert.IsTrue(RegexValidation.ValidatingEmail(email));
        }
    }
}
